using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WilsonTeaRoom.Dto;
using WilsonTeaRoom.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WilsonTeaRoom.Controllers.Api
{
    public class FoodsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Foods
        public IQueryable<FoodDto> GetFoods()
        {
            var food = from f in db.Foods
                       select new FoodDto()
                       {
                           ID = f.ID,
                           Name = f.Name,
                           Price = f.Price,
                           Category = f.Category.Name,
                           CategoryId = f.Category.ID
                       };
            return food;
        }

        // GET: api/Foods/5
        [ResponseType(typeof(FoodDetailDto))]
        public async Task<IHttpActionResult> GetFood(int id)
        {
            var food = await db.Foods.Include(f => f.Category).Select(f =>
              new FoodDetailDto()
              {
                  ID = f.ID,
                  Name = f.Name,
                  Price = f.Price,
                  CategoryId = f.Category.ID,
                  CategoryName = f.Category.Name,
                  Description = f.Description,
                  IsVisible = f.IsVisible
              }).SingleOrDefaultAsync(f => f.ID == id);
            if (food == null)
            {
                return NotFound();
            }

            return Ok(food);
        }

        // PUT: api/Foods/5
        [ResponseType(typeof(void))]
        [HttpPut]
        public async Task<IHttpActionResult> UpdateFood(int id, Food food)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != food.ID)
            {
                return BadRequest();
            }

            var foodindb = db.Foods.Where(s => s.ID == food.ID).FirstOrDefault<Food>();

            try
            {
                if (foodindb != null)
                {
                    foodindb.Name = food.Name;
                    foodindb.Price = food.Price;
                    foodindb.CategoryId = food.CategoryId;
                    foodindb.Description = food.Description;
                    foodindb.IsVisible = food.IsVisible;
                    await db.SaveChangesAsync();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok();
        }

        // POST: api/Foods
        [ResponseType(typeof(Food))]
        [HttpPost]
        public async Task<IHttpActionResult> CreateFood(Food food)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Foods.Add(food);
            await db.SaveChangesAsync();
            db.Entry(food).Reference(x => x.Category).Load();

            var dto = new FoodDetailDto()
            {
                ID = food.ID,
                Name = food.Name,
                Price = food.Price,
                CategoryId = food.Category.ID,
                Description = food.Description,
                IsVisible = food.IsVisible
            };

            return CreatedAtRoute("DefaultApi", new { id = food.ID }, dto);
        }

        // DELETE: api/Foods/5
        [ResponseType(typeof(Food))]
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteFood(int id)
        {
            var food = db.Foods.Where(s => s.ID == id).FirstOrDefault();
            if (food == null)
            {
                return NotFound();
            }

            db.Foods.Remove(food);
            await db.SaveChangesAsync();

            return Ok(food);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
