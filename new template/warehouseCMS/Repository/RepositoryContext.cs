using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using warehouseCMS.Data;

namespace warehouseCMS.Repository
{
    public class RepositoryContext : DataAccess
    {
        //private ILoggerManager _logger;
        protected CmsContext _context;

        public RepositoryContext(CmsContext context){
            _context = context;
        }
        public DbFetchOutData FecthQuery(string sqlText, Dictionary<string, string> param)
        {
            //_logger.LogDebug("FecthQuery");
            //ResultObj Rsobj = new ResultObj();
            //Rsobj.Name = "ERR_MSG";
            DbConnection connection = null;
            DbCommand cmd = null;
            DbFetchOutData OutData = null;
            try
            {
                // get connection from _context -> using Dapper
                //dotnet add package Dapper --version 1.60.6
                connection = _context.Database.GetDbConnection();
                connection.Open();
                cmd = BuildCommand(connection, sqlText, param);
                var reader = cmd.ExecuteReader();
                OutData = BuildOutputReader(reader);
                reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                //_logger.LogError(e.Message);
            }
            finally{
                try
                {
                    if(cmd != null)
                    {
                        cmd.Dispose();
                    }
                    connection.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            return OutData;
        }

        public List<ResultObj> ExecuteProcedure(string sqlText, List<ParamObj> param)
        {
            List<ResultObj> result = new List<ResultObj>();
            DbConnection connection = null;
            DbCommand cmd = null;
            try
            {
                connection = _context.Database.GetDbConnection();
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = sqlText;
                foreach(var data in param){
                    var pr = cmd.CreateParameter();
                    pr.ParameterName = "@" + data.Name;
                    if(data.Direction == ParameterDirection.Input)
                    {
                        pr.Value = data.Value;
                    }
                    pr.DbType = data.Type;
                    pr.Direction = data.Direction;
                    cmd.Parameters.Add(pr);
                }
                Console.WriteLine("Call procedure");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Execute DONE");
                foreach(var data in param){
                    
                    if(data.Direction == ParameterDirection.Output)
                    {
                        var val = Convert.ToString(cmd.Parameters["@"+data.Name].Value);
                        ResultObj rs = new ResultObj(data.Name, val);
                        result.Add(rs);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                //_logger.LogError(e.Message);
            }
            finally{
                try
                {
                    if(cmd != null)
                    {
                        cmd.Dispose();
                    }
                    connection.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            return result;
        }

        public void ExecuteQuery(string queryType, string sqlText, Dictionary<string, string> param, ref DbFetchOutData outdata)
        {
            DbConnection connection = null;
            DbCommand cmd = null;
            try
            {
                connection = _context.Database.GetDbConnection();
                connection.Open();
                cmd = BuildCommand(connection, sqlText, param);
                switch(queryType)
                {
                    case "DEL" :
                        Console.WriteLine("Delete data");
                        cmd.ExecuteNonQuery();
                        break;
                    case "INS" :
                        Console.WriteLine("Insert data");
                        Console.WriteLine("sqlText :" + sqlText);
                        cmd.ExecuteNonQuery();
                        break;
                    case "UPD" :
                        Console.WriteLine("Update data");
                        cmd.ExecuteNonQuery();
                        break;
                    case "PRO" :
                        Console.WriteLine("Call procedure");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        /*var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(1));
                        }
                        reader.Close();*/
                        //outdata = BuildOutputReader(reader);
                        break;
                    default:
                        throw new Exception("the method " + queryType + " is not supported");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                //_logger.LogError(e.Message);
            }
            finally{
                try
                {
                    if(cmd != null)
                    {
                        cmd.Dispose();
                    }
                    connection.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
        }

        public DbCommand BuildCommand(DbConnection con, string sqlText, Dictionary<string, string> param)
        {
            DbCommand cmd = con.CreateCommand();
            cmd.CommandText = sqlText;
            foreach(var data in param){
                var pr = cmd.CreateParameter();
                pr.ParameterName = "@" + data.Key;
                pr.Value = data.Value;
                //pr.DbType = DbType.Int64;
                //pr.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pr);
            }
            Console.WriteLine("BuildCommand DONE ");
            return cmd;
        }
        public DbFetchOutData BuildOutputReader(DbDataReader reader)
        {
            DbFetchOutData OutData = new DbFetchOutData();
            Dictionary<int, string> header = new Dictionary<int, string>();
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            Dictionary<string, string> row = null;
            int colunms = reader.FieldCount;
            for (int colidx = 0; colidx <= reader.FieldCount - 1; colidx++) {
                header.Add(colidx, reader.GetName(colidx).ToUpper());
            }
            OutData.Header = header;
            while (reader.Read())
            {
                row = new Dictionary<string, string>();
                for (int colidx = 0; colidx < colunms; colidx++) {
                        string colName = reader.GetName(colidx);
                        if(!reader.IsDBNull(colidx))
                        {
                            row.Add(colName.ToUpper(), reader.GetString(colidx));
                        }
                        else
                        {
                            row.Add(colName, "");
                        }
                }
                data.Add(row);
            }
            OutData.Data = data;

            return OutData;
        }
    }
}