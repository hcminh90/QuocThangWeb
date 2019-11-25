using System.Collections.Generic;

namespace warehouseCMS.Data
{
    public class DbFetchOutData
    {
        public Dictionary<int, string> Header {set; get;}
        public List<Dictionary<string, string>> Data {set; get;}
        public DbFetchOutData()
        {

        }
        protected DbFetchOutData(Dictionary<int, string> header, List<Dictionary<string, string>> data)
        {
            Header = header;
            Data = data;
        }
    }
}