using Healt_Food.Server.DAL;
using Healt_Food.Shared.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Healt_Food.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        public FoodController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<List<Food>> GetAllAsync()
        {
            var result = await _dbContext.Foods.ToListAsync();

            return result;
        }

        [HttpGet("GetFavorites")]
        public async Task<List<Food>> GetFavoritesFood()
        {
            var foods = await _dbContext.Foods.ToListAsync();

            return foods.Where(x => x.Favorite == true).ToList();
        }

        [HttpPut]
        public async Task<IActionResult> AddToFavorite(Food food)
        {
            var foodLast = await _dbContext.Foods.FirstOrDefaultAsync(x => x.Id == food.Id);

            foodLast.Fat = food.Fat;
            foodLast.Favorite = food.Favorite;
            foodLast.DayOfWeek = food.DayOfWeek;
            foodLast.Calories = food.Calories;
            foodLast.Carbohydrates = food.Carbohydrates;
            foodLast.Protein = food.Protein;

            _dbContext.Update(foodLast);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

    }
}
