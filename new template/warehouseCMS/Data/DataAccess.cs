using System.Collections.Generic;

namespace warehouseCMS.Data
{
    public interface DataAccess
    {
         DbFetchOutData FecthQuery(string sqlText, Dictionary<string, string> param, ref string exception);

         void ExecuteQuery(string queryType, string sqlText, Dictionary<string, string> param, ref DbFetchOutData outdata, ref string exception);

         List<ResultObj> ExecuteProcedure(string sqlText, List<ParamObj> param, ref string exception);

         DbFetchOutData ExecuteReaderProcedure(string sqlText, List<ParamObj> param, ref string exception);
    }
}