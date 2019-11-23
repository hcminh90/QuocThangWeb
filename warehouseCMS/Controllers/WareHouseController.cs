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

        public IActionResult Customer()
        {
            ViewBag.Error="NO";
            return View();
        }

        public IActionResult Product()
        {
            ViewBag.Error="NO";
            return View();
        }

        [HttpPost]
        public IActionResult Customer(string CusName, string TaxID, string CusAddr, string CusPhone, string CusEmail)
        {
            DbFetchOutData outdata = new DbFetchOutData();
            Dictionary<string, string> param;
            string  sqlText = "INSERT INTO customers(CUST_NAME, CUST_TAX, CUST_ADDRESS, CUST_PHONE_NUMBER, CUST_EMAIL) values(@CUST_NAME, @CUST_TAX, @CUST_ADDRESS, @CUST_PHONE_NUMBER, @CUST_EMAIL)";
            param = new Dictionary<string, string>();
            param.Add("CUST_NAME",CusName);
            param.Add("CUST_TAX",TaxID);
            param.Add("CUST_ADDRESS",CusAddr);
            param.Add("CUST_PHONE_NUMBER",CusPhone);
            param.Add("CUST_EMAIL",CusEmail);
            _da.ExecuteQuery("INS", sqlText, param, ref outdata);
            ViewBag.Error="SUCCESS";
            return View();
        }

        [HttpPost]
        public IActionResult Product(string ProdName, string ProdDesc, string ProdIUnit, string ProdPrice)
        {
            DbFetchOutData outdata = new DbFetchOutData();
            Dictionary<string, string> param;
            string  sqlText = "INSERT INTO products(PROD_NAME, PROD_DESC, PROD_UNIT, PROD_UNIT_PRICE, PROD_AMOUNT) values(@PROD_NAME, @PROD_DESC, @PROD_UNIT, @PROD_UNIT_PRICE, @PROD_AMOUNT)";
            param = new Dictionary<string, string>();
            param.Add("PROD_NAME",ProdName);
            param.Add("PROD_DESC",ProdDesc);
            param.Add("PROD_UNIT",ProdIUnit);
            param.Add("PROD_UNIT_PRICE",ProdPrice);
            param.Add("PROD_AMOUNT","0");
            _da.ExecuteQuery("INS", sqlText, param, ref outdata);
            ViewBag.Error="SUCCESS";
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
