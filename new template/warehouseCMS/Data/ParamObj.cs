using System.Data;

namespace warehouseCMS.Data
{
    public class ParamObj
    {
        public string Name{ get; set;}
        public string Value{ get; set;}
        public DbType Type{ get; set;}
        public ParameterDirection Direction{ get; set;}
        public ParamObj(string name, string value, DbType type, ParameterDirection direction)
        {
            Name = name;
            Value = value;
            Type = type;
            Direction = direction;
        }
    }
}