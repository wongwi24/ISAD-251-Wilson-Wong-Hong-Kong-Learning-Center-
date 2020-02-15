using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WilsonTeaRoom.Models;
using PagedList;

namespace WilsonTeaRoom.Controllers
{
    public class FoodController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Food
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.CategorySortParm = sortOrder=="Category" ? "category_desc" : "Category";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var foods = db.Foods.Include(f => f.Category);
            if (!String.IsNullOrEmpty(searchString))
            {
                foods = foods.Where(s => s.Name.Contains(searchString) || s.Category.Name.Contains(searchString));
            }
                switch (sortOrder)
            {
                case "name_desc":
                    foods = foods.OrderByDescending(s => s.Name);
                    break;
                case "Category":
                    foods = foods.OrderBy(s => s.Category.Name);
                    break;
                case "category_desc":
                    foods = foods.OrderByDescending(s => s.Category.Name);
                    break;
                case "Price":
                    foods = foods.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    foods = foods.OrderByDescending(s => s.Price);
                    break;
                default:
                    foods = foods.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(foods.ToPagedList(pageNumber, pageSize));
        }

        // GET: Food/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food food = await db.Foods.FindAsync(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        // GET: Food/Create
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "ID", "Name");
            return View();
        }

        // POST: Food/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Create([Bind(Include = "CategoryId,Name,Description,Price,FoodPictureUrl,IsVisible")] Food food)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Foods.Add(food);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException dex )
            {
                //Log the error
                ModelState.AddModelError("", "Unable to save changes. Try again or contact our admin");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "ID", "Name", food.CategoryId);
            return View(food);
        }

        // GET: Food/Edit/5
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food food = await db.Foods.FindAsync(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "ID", "Name", food.CategoryId);
            return View(food);
        }

        // POST: Food/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var foodToUpdate = await db.Foods.FindAsync(id);
            if (TryUpdateModel(foodToUpdate, "", new string[] { "CategoryId", "Name", "Description", "Price", "FoodPictureUrl", "IsVisible" }))
            {
                try
                {
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch (DataException /* dex */)
                { //Log the error
                    ModelState.AddModelError("", "Unable to save changes. Try again or contact our Admin.");
                }
                ViewBag.CategoryId = new SelectList(db.Categories, "ID", "Name", foodToUpdate.CategoryId);
            }
            return View(foodToUpdate);
        }

        // GET: Food/Delete/5
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again or contact our Admin.";
            }
            Food food = await db.Foods.FindAsync(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        // POST: Food/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                Food food = await db.Foods.FindAsync(id);
                db.Foods.Remove(food);
                await db.SaveChangesAsync();
            }
            catch (DataException dex)
            {
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
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
