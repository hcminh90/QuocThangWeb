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
    public class WareHouseController : Controller
    {
        private DataAccess _da;

        public WareHouseController(DataAccess da)
        {
            _da = da;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Input()
        {
            string sqlText = "select * from customers a;";
            Dictionary<string, string> param = new Dictionary<string, string>();
            DbFetchOutData outdata = _da.FecthQuery(sqlText, param);
            ViewData["Customers"] = outdata;

            sqlText = "select * from products a;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param);
            ViewData["Products"] = outdata;
            ViewBag.Error="NO";
            return View();
        }

        [HttpPost]
        public IActionResult Input(string CusID, string OrderInfo)
        {
            Console.WriteLine("CusID :" + CusID);
            Console.WriteLine("OrderInfo :" + OrderInfo);
            var loggedInUser = HttpContext.User;
            var loggedInUserName = loggedInUser.Identity.Name;
            string sqlTextuser = "SELECT * FROM users WHERE USER_PEOPLE_ID = @username;";
            Dictionary<string, string> paramUser = new Dictionary<string, string>();
            paramUser.Add("username",loggedInUserName);
            DbFetchOutData outuser = _da.FecthQuery(sqlTextuser, paramUser);
            var userid = outuser.Data[0]["USER_ID"];

            var taxid = "";
            var erro_no="000000";
            string[] trans = OrderInfo.Split(';');
            DbFetchOutData outdata = new DbFetchOutData();
            Dictionary<string, string> param;
            string  sqlText = "INSERT INTO transcations(TAX_ID, PROD_ID, CUST_ID, USER_ID, TIMESTAMP, UNIT_PRICE, UNIT_AMOUNT, UNIT_PAY, TRANSACTION, TRANSACTION_DESC) values(@TAX_ID, @PROD_ID, @CUST_ID, @USER_ID, @TIMESTAMP, @UNIT_PRICE, @UNIT_AMOUNT, @UNIT_PAY, @TRANSACTION, @TRANSACTION_DESC)";
            if(trans.Length>0){
                List<ParamObj> paramPro = new List<ParamObj>();
                ParamObj par = new ParamObj("outtax_id","",DbType.String, ParameterDirection.Output);
                paramPro.Add(par);
                List<ResultObj> execPro = _da.ExecuteProcedure("ProcGenTax", paramPro);
                if(execPro != null){
                    taxid = execPro[0].Value;
                    Console.WriteLine("taxid :" + taxid);
                }
                else{
                    erro_no = "900900";
                }
            }

            if(erro_no == "000000"){
                for(int i=0; i< trans.Length;i++){
                    var tran = trans[i];
                    var fields = tran.Split('~');
                    param = new Dictionary<string, string>();
                    param.Add("TAX_ID",taxid);
                    param.Add("PROD_ID",fields[1]);
                    param.Add("CUST_ID",CusID);
                    param.Add("USER_ID",userid);
                    param.Add("TIMESTAMP",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    param.Add("UNIT_PRICE",fields[3]);
                    param.Add("UNIT_AMOUNT",fields[2]);
                    param.Add("UNIT_PAY",fields[4]);
                    param.Add("TRANSACTION","buy");
                    param.Add("TRANSACTION_DESC","buy");
                    _da.ExecuteQuery("INS", sqlText, param, ref outdata);
                }
                ViewBag.Error="SUCCESS";
            }
            else{
                ViewBag.Error = "Không lấy được mã hóa đơn";
            }

            sqlText = "select * from customers a;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param);
            ViewData["Customers"] = outdata;

            sqlText = "select * from products a;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param);
            ViewData["Products"] = outdata;

            return View();
        }

        public IActionResult Output()
        {
            string sqlText = "select * from customers a;";
            Dictionary<string, string> param = new Dictionary<string, string>();
            DbFetchOutData outdata = _da.FecthQuery(sqlText, param);
            ViewData["Customers"] = outdata;

            sqlText = "select * from products a;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param);
            ViewData["Products"] = outdata;
            ViewBag.Error="NO";

            return View();
        }

        [HttpPost]
        public IActionResult Output(string CusID, string OrderInfo)
        {
            Console.WriteLine("CusID :" + CusID);
            Console.WriteLine("OrderInfo :" + OrderInfo);
            var loggedInUser = HttpContext.User;
            var loggedInUserName = loggedInUser.Identity.Name;
            string sqlTextuser = "SELECT * FROM users WHERE USER_PEOPLE_ID = @username;";
            Dictionary<string, string> paramUser = new Dictionary<string, string>();
            paramUser.Add("username",loggedInUserName);
            DbFetchOutData outuser = _da.FecthQuery(sqlTextuser, paramUser);
            var userid = outuser.Data[0]["USER_ID"];

            var taxid = "";
            var erro_no="000000";
            string[] trans = OrderInfo.Split(';');
            DbFetchOutData outdata = new DbFetchOutData();
            Dictionary<string, string> param;
            string  sqlText = "INSERT INTO transcations(TAX_ID, PROD_ID, CUST_ID, USER_ID, TIMESTAMP, UNIT_PRICE, UNIT_AMOUNT, UNIT_PAY, TRANSACTION, TRANSACTION_DESC) values(@TAX_ID, @PROD_ID, @CUST_ID, @USER_ID, @TIMESTAMP, @UNIT_PRICE, @UNIT_AMOUNT, @UNIT_PAY, @TRANSACTION, @TRANSACTION_DESC)";
            if(trans.Length>0){
                List<ParamObj> paramPro = new List<ParamObj>();
                ParamObj par = new ParamObj("outtax_id","",DbType.String, ParameterDirection.Output);
                paramPro.Add(par);
                List<ResultObj> execPro = _da.ExecuteProcedure("ProcGenTax", paramPro);
                if(execPro != null){
                    taxid = execPro[0].Value;
                    Console.WriteLine("taxid :" + taxid);
                }
                else{
                    erro_no = "900900";
                }
            }

            if(erro_no == "000000"){
                for(int i=0; i< trans.Length;i++){
                    var tran = trans[i];
                    var fields = tran.Split('~');
                    param = new Dictionary<string, string>();
                    param.Add("TAX_ID",taxid);
                    param.Add("PROD_ID",fields[1]);
                    param.Add("CUST_ID",CusID);
                    param.Add("USER_ID",userid);
                    param.Add("TIMESTAMP",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    param.Add("UNIT_PRICE",fields[3]);
                    param.Add("UNIT_AMOUNT",fields[2]);
                    param.Add("UNIT_PAY",fields[4]);
                    param.Add("TRANSACTION","sell");
                    param.Add("TRANSACTION_DESC","sell");
                    _da.ExecuteQuery("INS", sqlText, param, ref outdata);
                }
                ViewBag.Error="SUCCESS";
            }
            else{
                ViewBag.Error = "Không lấy được mã hóa đơn";
            }

            sqlText = "select * from customers a;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param);
            ViewData["Customers"] = outdata;

            sqlText = "select * from products a;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param);
            ViewData["Products"] = outdata;

            return View();
        }

        public IActionResult Report()
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
