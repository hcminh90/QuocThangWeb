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
            //user_id = GetUserID();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Input()
        {
            string exp="";
            string sqlText = "select * from customers a;";
            Dictionary<string, string> param = new Dictionary<string, string>();
            DbFetchOutData outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Customers"] = outdata;

            sqlText = "select * from products a order by 2;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Products"] = outdata;
            ViewBag.Error="NO";
            return View();
        }

        public string GetUserID(string user_name)
        {
            string exp = "";
            string sqlTextuser = "SELECT * FROM users WHERE USER_PEOPLE_ID = @username;";
            Dictionary<string, string> paramUser = new Dictionary<string, string>();
            paramUser.Add("username",user_name);
            DbFetchOutData outuser = _da.FecthQuery(sqlTextuser, paramUser, ref exp);
            var userid = outuser.Data[0]["USER_ID"];
            return userid;
        }

        [HttpPost]
        public IActionResult Input(string CusID, string OrderInfo)
        {
            Console.WriteLine("CusID :" + CusID);
            Console.WriteLine("OrderInfo :" + OrderInfo);
            string exp = "";
            var cus = CusID.Split('-')[0];
            Console.WriteLine("cus :" + cus);
            var loggedInUser = HttpContext.User;
            var user_name = loggedInUser.Identity.Name;
            var user_id = GetUserID(user_name);
            var taxid = "";
            var erro_no="000000";
            string[] trans = OrderInfo.Split(';');
            DbFetchOutData outdata = new DbFetchOutData();
            Dictionary<string, string> param;
            string  sqlText = "INSERT INTO transactions(TAX_ID, PROD_ID, CUST_ID, USER_ID, TIMESTAMP, UNIT_PRICE, UNIT_AMOUNT, UNIT_PAY, TRANSACTION, TRANSACTION_DESC, PROD_UNIT_PRICE, UNIT_PRE_AMOUNT) values(@TAX_ID, @PROD_ID, @CUST_ID, @USER_ID, @TIMESTAMP, @UNIT_PRICE, @UNIT_AMOUNT, @UNIT_PAY, @TRANSACTION, @TRANSACTION_DESC, @PROD_UNIT_PRICE, @UNIT_PRE_AMOUNT)";
            if(trans.Length>0){
                List<ParamObj> paramPro = new List<ParamObj>();
                ParamObj par = new ParamObj("outtax_id","",DbType.String, ParameterDirection.Output);
                paramPro.Add(par);
                List<ResultObj> execPro = _da.ExecuteProcedure("ProcGenTax", paramPro, ref exp);
                if(exp != "000000"){
                    ViewBag.Error = exp;
                    return View("ErrorPage");
                }
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
                    param.Add("CUST_ID",cus);
                    param.Add("USER_ID",user_id);
                    param.Add("TIMESTAMP",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    param.Add("UNIT_PRICE",fields[3]);
                    param.Add("UNIT_AMOUNT",fields[2]);
                    param.Add("UNIT_PAY",fields[4]);
                    param.Add("TRANSACTION","buy");
                    param.Add("TRANSACTION_DESC","buy");
                    param.Add("PROD_UNIT_PRICE",fields[5]);
                    param.Add("UNIT_PRE_AMOUNT",fields[6]);
                    _da.ExecuteQuery("INS", sqlText, param, ref outdata, ref exp);
                    if(exp != "000000"){
                        ViewBag.Error = exp;
                        return View("ErrorPage");
                    }
                }
                ViewBag.Error="SUCCESS";
            }
            else{
                ViewBag.Error = "Không lấy được mã hóa đơn";
            }

            sqlText = "select * from customers a;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Customers"] = outdata;

            sqlText = "select * from products a;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Products"] = outdata;
            ViewBag.BackController = "WareHouse";
            ViewBag.BackAction = "Input";

            return View("ResponeProcess");
        }

        public IActionResult Output()
        {
            string exp = "";
            string sqlText = "select * from customers a;";
            Dictionary<string, string> param = new Dictionary<string, string>();
            DbFetchOutData outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Customers"] = outdata;

            sqlText = "select * from products a order by 2;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Products"] = outdata;
            ViewBag.Error="NO";

            return View();
        }

        [HttpPost]
        public IActionResult Output(string CusID, string OrderInfo)
        {
            Console.WriteLine("CusID :" + CusID);
            Console.WriteLine("OrderInfo :" + OrderInfo);
            string exp = "";
            var cus = CusID.Split('-')[0];
            Console.WriteLine("cus :" + cus);
            var loggedInUser = HttpContext.User;
            var user_name = loggedInUser.Identity.Name;
            var user_id = GetUserID(user_name);
            var taxid = "";
            var erro_no="000000";
            string[] trans = OrderInfo.Split(';');
            DbFetchOutData outdata = new DbFetchOutData();
            Dictionary<string, string> param;
            string  sqlText = "INSERT INTO transactions(TAX_ID, PROD_ID, CUST_ID, USER_ID, TIMESTAMP, UNIT_PRICE, UNIT_AMOUNT, UNIT_PAY, TRANSACTION, TRANSACTION_DESC, PROD_UNIT_PRICE) values(@TAX_ID, @PROD_ID, @CUST_ID, @USER_ID, @TIMESTAMP, @UNIT_PRICE, @UNIT_AMOUNT, @UNIT_PAY, @TRANSACTION, @TRANSACTION_DESC, @PROD_UNIT_PRICE)";
            if(trans.Length>0){
                List<ParamObj> paramPro = new List<ParamObj>();
                ParamObj par = new ParamObj("outtax_id","",DbType.String, ParameterDirection.Output);
                paramPro.Add(par);
                List<ResultObj> execPro = _da.ExecuteProcedure("ProcGenTax", paramPro, ref exp);
                if(exp != "000000"){
                    ViewBag.Error = exp;
                    return View("ErrorPage");
                }
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
                    param.Add("CUST_ID",cus);
                    param.Add("USER_ID",user_id);
                    param.Add("TIMESTAMP",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    param.Add("UNIT_PRICE",fields[3]);
                    param.Add("UNIT_AMOUNT",fields[2]);
                    param.Add("UNIT_PAY",fields[4]);
                    param.Add("TRANSACTION","sell");
                    param.Add("TRANSACTION_DESC","sell");
                    param.Add("PROD_UNIT_PRICE",fields[5]);
                    _da.ExecuteQuery("INS", sqlText, param, ref outdata, ref exp);
                    if(exp != "000000"){
                        ViewBag.Error = exp;
                        return View("ErrorPage");
                    }
                }
                ViewBag.Error="SUCCESS";
            }
            else{
                ViewBag.Error = "Không lấy được mã hóa đơn";
            }

            sqlText = "select * from customers a;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Customers"] = outdata;

            sqlText = "select * from products a;";
            param = new Dictionary<string, string>();
            outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Products"] = outdata;

            ViewBag.BackController = "WareHouse";
            ViewBag.BackAction = "Output";

            return View("ResponeProcess");
        }

        public IActionResult Customer()
        {
            ViewBag.Error="NO";
            return View();
        }

        public IActionResult CustomerShow()
        {
            string exp = "";
            string sqlText = "select * from customers a;";
            Dictionary<string, string> param = new Dictionary<string, string>();
            DbFetchOutData outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Customers"] = outdata;
            return View();
        }

        public IActionResult Product()
        {
            string exp = "";
            string sqlText = "select * from products a;";
            Dictionary<string, string> param = new Dictionary<string, string>();
            DbFetchOutData outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Products"] = outdata;
            ViewBag.Error="NO";
            return View();
        }

        public IActionResult ProductShow()
        {
            string exp = "";
            string sqlText = "select a.*, (select  USER_NAME from qt.users where user_id = a.PROD_LAST_USER_CHANGED) USER_NAME from products a order by 2;";
            Dictionary<string, string> param = new Dictionary<string, string>();
            DbFetchOutData outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Products"] = outdata;
            return View();
        }

        public IActionResult ProductUpdate(string id)
        {
            Console.WriteLine("minhhc pro_id: " + id);
            string exp = "";
            string sqlText = "select a.*, (select  USER_NAME from qt.users where user_id = a.PROD_LAST_USER_CHANGED) USER_NAME from products a where PROD_ID = @PROD_ID;";
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("PROD_ID",id);
            DbFetchOutData outdata = _da.FecthQuery(sqlText, param, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewData["Products"] = outdata;
            return View();
        }

        [HttpPost]
        public IActionResult ProductUpdate(string proId, string ProdName, string ProdDesc, string ProdIUnit, string ProdPrice)
        {
            Console.Write("minhhc update proId:"+ proId);
            string exp = "";
            var loggedInUser = HttpContext.User;
            var user_name = loggedInUser.Identity.Name;
            var user_id = GetUserID(user_name);
            DbFetchOutData outdata = new DbFetchOutData();
            Dictionary<string, string> param;
            string  sqlText = "UPDATE products SET PROD_NAME = @PROD_NAME, PROD_DESC = @PROD_DESC, PROD_UNIT = @PROD_UNIT, PROD_UNIT_PRICE = @PROD_UNIT_PRICE, PROD_LAST_USER_CHANGED = @PROD_LAST_USER_CHANGED, PROD_LAST_TIME_CHANGED = @PROD_LAST_TIME_CHANGED WHERE PROD_ID = @PROD_ID;";
            param = new Dictionary<string, string>();
            param.Add("PROD_ID",proId);
            param.Add("PROD_NAME",ProdName);
            param.Add("PROD_DESC",ProdDesc);
            param.Add("PROD_UNIT",ProdIUnit);
            param.Add("PROD_UNIT_PRICE",ProdPrice.Replace(",", ""));
            param.Add("PROD_LAST_USER_CHANGED",user_id);
            param.Add("PROD_LAST_TIME_CHANGED",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            _da.ExecuteQuery("UPD", sqlText, param, ref outdata, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewBag.Error="SUCCESS";
            ViewBag.BackController = "WareHouse";
            ViewBag.BackAction = "ProductShow";

            return View("ResponeProcess");
        }

        [HttpPost]
        public IActionResult Customer(string CusName, string TaxID, string CusAddr, string CusPhone, string CusEmail)
        {
            string exp = "";
            DbFetchOutData outdata = new DbFetchOutData();
            Dictionary<string, string> param;
            string  sqlText = "INSERT INTO customers(CUST_NAME, CUST_TAX, CUST_ADDRESS, CUST_PHONE_NUMBER, CUST_EMAIL) values(@CUST_NAME, @CUST_TAX, @CUST_ADDRESS, @CUST_PHONE_NUMBER, @CUST_EMAIL)";
            param = new Dictionary<string, string>();
            param.Add("CUST_NAME",CusName);
            param.Add("CUST_TAX",TaxID);
            param.Add("CUST_ADDRESS",CusAddr);
            param.Add("CUST_PHONE_NUMBER",CusPhone);
            param.Add("CUST_EMAIL",CusEmail);
            _da.ExecuteQuery("INS", sqlText, param, ref outdata, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewBag.Error="SUCCESS";
            ViewBag.BackController = "WareHouse";
            ViewBag.BackAction = "Customer";

            return View("ResponeProcess");
        }

        [HttpPost]
        public IActionResult Product(string ProdName, string ProdDesc, string ProdIUnit, string ProdPrice)
        {
            string exp = "";
            var loggedInUser = HttpContext.User;
            var user_name = loggedInUser.Identity.Name;
            var user_id = GetUserID(user_name);
            DbFetchOutData outdata = new DbFetchOutData();
            Dictionary<string, string> param;
            string  sqlText = "INSERT INTO products(PROD_NAME, PROD_DESC, PROD_UNIT, PROD_UNIT_PRICE, PROD_AMOUNT, PROD_LAST_USER_CHANGED, PROD_LAST_TIME_CHANGED) values(@PROD_NAME, @PROD_DESC, @PROD_UNIT, @PROD_UNIT_PRICE, @PROD_AMOUNT, @PROD_LAST_USER_CHANGED, @PROD_LAST_TIME_CHANGED)";
            param = new Dictionary<string, string>();
            param.Add("PROD_NAME",ProdName);
            param.Add("PROD_DESC",ProdDesc);
            param.Add("PROD_UNIT",ProdIUnit);
            param.Add("PROD_UNIT_PRICE",ProdPrice.Replace(",", ""));
            param.Add("PROD_AMOUNT","0");
            param.Add("PROD_LAST_USER_CHANGED",user_id);
            param.Add("PROD_LAST_TIME_CHANGED",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            _da.ExecuteQuery("INS", sqlText, param, ref outdata, ref exp);
            if(exp != "000000"){
                ViewBag.Error = exp;
                return View("ErrorPage");
            }
            ViewBag.Error="SUCCESS";
            ViewBag.BackController = "WareHouse";
            ViewBag.BackAction = "Product";

            return View("ResponeProcess");
        }

        public JsonResult PopulationChart()
        {
            var populationList = PopulationDataAccessaLayer.GetCityPopulationList();
            Console.WriteLine("populationList: " + Json(populationList));
            return Json(populationList);
        }

        public IActionResult Report()
        {
            return View();
        }

        public IActionResult ResponeProcess()
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
