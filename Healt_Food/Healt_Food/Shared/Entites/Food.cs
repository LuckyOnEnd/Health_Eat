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
        public bool InMonday { get; set; }
        public bool InTuesday { get; set; }
        public bool InWednesday { get; set; }
        public bool InThursday { get; set; }
        public bool InFriday { get; set; }
        public bool InSaturday { get; set; }
        public bool InSunday { get; set; }
    }
}
