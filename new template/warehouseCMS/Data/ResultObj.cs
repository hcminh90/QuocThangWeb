namespace warehouseCMS.Data
{
    public class ResultObj
    {
        public string Name{ get; set;}
        public string Value{ get; set;}
        public ResultObj()
        {
            
        }
        public ResultObj(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}