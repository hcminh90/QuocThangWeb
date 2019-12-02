using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using warehouseCMS.Data;
using warehouseCMS.Models;

namespace warehouseCMS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private DataAccess _da;

        public HomeController(DataAccess da)
        {
            _da = da;
            //user_id = GetUserID();
        }

        public IActionResult Index()
        {
            string exp="";
            string sqlText = "select * from products a  LIMIT  20;";
            Dictionary<string, string> param = new Dictionary<string, string>();
            DbFetchOutData outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Products"] = outdata;

            sqlText = "select * from ("+
                        "SELECT TAX_ID, "+
                        "(select prod_name from qt.products where PROD_ID=a.PROD_ID) PROD_NAME,"+
                        "(select cust_name from qt.customers where cust_ID=a.CUST_ID) CUST_NAME,"+
                        "UNIT_AMOUNT,"+
                        "if(TRANSACTION='sell','Xuất kho','Nhập kho') TRANSACTION,"+
                        "TIMESTAMP "+
                        "FROM qt.transactions a order by TIMESTAMP desc) as a LIMIT 10;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Transactions"] = outdata;

            sqlText = "select * from customers a;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Customers"] = outdata;

            DateTime now = DateTime.Now;
            string sDate = now.Month-1+"/01/"+now.Year;
            ViewBag.StartDate = Convert.ToDateTime(sDate).ToString("dd/MM/yyyy");
            List<ParamObj> paramPro = new List<ParamObj>();
            paramPro.Add(new ParamObj("start_date",sDate,DbType.Date, ParameterDirection.Input));
            paramPro.Add(new ParamObj("end_date",DateTime.Now.ToString(),DbType.Date, ParameterDirection.Input));
            DbFetchOutData outdataPro = _da.ExecuteReaderProcedure("ProcDashBoard", paramPro, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Report"] = outdataPro;
            //Console.WriteLine("AMOUNT_TRAN: " + outdataPro.Data[0]["AMOUNT_TRAN"]);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
