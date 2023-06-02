using HealthEat.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEat.Core.DAL
{
    public class Context
    {
        public List<FoodInfo> Foods { get; set;}
        public List<Favorites> Favorites { get; set;}
        public List<WeeklyPlan> WeeklyPlans { get; set;}
    }
}
