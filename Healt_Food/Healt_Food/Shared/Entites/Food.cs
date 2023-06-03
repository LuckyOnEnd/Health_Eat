using Healt_Food.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healt_Food.Shared.Entites
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
        public double Protein { get; set; }
        public double Calories { get; set; }
        public bool Favorite { get; set; }
        public DayOfWeekEnum DayOfWeek { get; set; }
    }
}
