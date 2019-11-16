using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using warehouseCMS.Models;

namespace warehouseCMS.Controllers
{
    public class AccountController : Controller
    {
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
            if(remeberme == "1")
            {
                RemeberMe = true;
            }
            if(IdentityUser(username, password))
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
            return View();
        }

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

        public bool IdentityUser(string username, string password)
        {
            return true;
        }
    }
}
