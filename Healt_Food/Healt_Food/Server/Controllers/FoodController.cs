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
            foodLast.InMonday = food.InMonday;
            foodLast.InTuesday = food.InTuesday;
            foodLast.InWednesday = food.InWednesday;
            foodLast.InThursday = food.InThursday;
            foodLast.InFriday = food.InFriday;
            foodLast.InSaturday = food.InSaturday;
            foodLast.InSunday = food.InSunday;
            foodLast.Calories = food.Calories;
            foodLast.Carbohydrates = food.Carbohydrates;
            foodLast.Protein = food.Protein;

            _dbContext.Update(foodLast);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateFood(Food food)
        {
            await _dbContext.AddAsync(food);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteFood(int Id)
        {
            var food = await _dbContext.Foods.FirstOrDefaultAsync(x => x.Id == Id);

            _dbContext.Remove(food);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
