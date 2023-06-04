using Healt_Food.Shared.Entites;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;

namespace Healt_Food.Client.ViewModel
{
    public class FoodViewModel
    {
        public Food _food { get; set; }

        public void SaveFood(Food food)
        {
            _food = food;
        }
    }
}
