using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEat.Core.Entities
{
    [Serializable]
    public class FoodInfo
    {
        public string Name { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set;}
        public double Protein { get; set; }
        public double Calories { get; set; }
    }
}
