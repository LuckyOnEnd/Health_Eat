using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEat.Core.Entities
{
    [Serializable]
    public class WeeklyPlan
    {
        public FoodInfo FoodInfo { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
    }
}
