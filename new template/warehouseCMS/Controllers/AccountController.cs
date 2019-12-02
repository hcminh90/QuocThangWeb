using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using warehouseCMS.Data;
using warehouseCMS.Models;
using warehouseCMS.Services;

namespace warehouseCMS.Controllers
{
    public class AccountController : Controller
    {
        
        private DataAccess _da;

        private IHostingEnvironment _hostingEnviroment;
        private readonly IEncrypter _encrypter;
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public AccountController(DataAccess da, IHostingEnvironment hostingEnviroment, IEncrypter encrypter)
        {
            _da = da;
            _hostingEnviroment = hostingEnviroment;
            _encrypter = encrypter;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            var loggedInUser = HttpContext.User;
            //Console.WriteLine("loggedInUser:"+loggedInUser);
            var loggedInUserName = loggedInUser.Identity.Name; // This is our username we set earlier in the claims. 
            Console.WriteLine("loggedInUserName:"+loggedInUserName);
            //var claimsPrincipal = loggedInUser.Claims;
            
            //var loggedInUserName2 = claimsPrincipal.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value; //Another way to get the name or any other claim we set. 
            //var loggedInUserN = ClaimsPrincipal.Current.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault();
            //Console.WriteLine("loggedInUserN:"+(loggedInUserN == null ? string.Empty : loggedInUserN.Value));
            
            if(!string.IsNullOrEmpty(loggedInUserName)){
                return Redirect("/Account/Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password, string remeberme)
        {
            bool RemeberMe = false;
            string exp ="";
            if(remeberme == "1")
            {
                RemeberMe = true;
            }
            if(IdentityUser(username, password, ref exp))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim("LastChanged",DateTime.Now.ToString())
                };
                
                var userIdentity = new ClaimsIdentity(claims, "login");
                
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal,new AuthenticationProperties { IsPersistent =  RemeberMe});

                /* set Expires time
                new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(20)
                }
                */
                
                //Just redirect to our index after logging in. 
                return Redirect("/");//RedirectToAction("Home","Index");
            }
            if(exp != "000000"){
                ViewData["Error"] = exp;
                return View("ErrorPage");
            }
            else{
                ViewData["Error"] = "Tên đăng nhập hoặc mật khẩu không hợp lệ!";
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
            //return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public bool IdentityUser(string username, string password, ref string expp)
        {
            if(string.IsNullOrWhiteSpace(password)){
                return false;
            }
            string exp = "";
            string sqlText = "SELECT * FROM users WHERE USER_PEOPLE_ID = @username;";
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("username",username);
            DbFetchOutData outdata = _da.FecthQuery(sqlText, param, ref exp);
            //ViewData["CbPost"] = outdata;
            /*SetPassWord(password, _encrypter);
            Console.WriteLine("Salt: " + Salt);
            Console.WriteLine("Password: " + Password);*/
            expp = exp;
            if(exp != "000000"){
                return false;
            }
            if(outdata.Data.Count>0)
            {
                var dbSalt = outdata.Data[0]["PWD_SALT"];
                var dbPass = outdata.Data[0]["USER_PASSWORD"];
                if(dbPass.Equals(_encrypter.GetHash(password,dbSalt)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void SetPassWord(string password, IEncrypter encrypter)
        {
            Salt = encrypter.GetSalt(password);
            Password = encrypter.GetHash(password, Salt);
        }

        public bool ValidatePassword(string password, IEncrypter encrypter)
        => Password.Equals(encrypter.GetHash(password,Salt));
    }
}
