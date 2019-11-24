using System.Collections.Generic;

namespace warehouseCMS.Models
{
    public class PopulationDataAccessaLayer
    {
        public static List<PopulationModel> GetCityPopulationList()  
        {  
            var list = new List<PopulationModel>();  
            list.Add(new PopulationModel { Month = "Tháng 09", Input = 28000, Ouput = 45000});  
            list.Add(new PopulationModel { Month = "Tháng 10", Input = 20000, Ouput = 19000}); 
            list.Add(new PopulationModel { Month = "Tháng 11", Input = 30000, Ouput = 150000}); 
            return list;  
  
        }
    }
}