using System.Collections.Generic;

namespace warehouseCMS.Data
{
    public interface DataAccess
    {
         DbFetchOutData FecthQuery(string sqlText, Dictionary<string, string> param);

         void ExecuteQuery(string queryType, string sqlText, Dictionary<string, string> param, ref DbFetchOutData outdata);
    }
}