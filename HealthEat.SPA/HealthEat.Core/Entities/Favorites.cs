using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEat.Core.Entities
{
    [Serializable]
    public class Favorites
    {
        public List<FoodInfo> Foods { get; set; }
    }
}
