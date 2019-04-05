using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShoppingList.DAL;
using ShoppingList.Models;

namespace ShoppingList.Controllers
{
    public class Ingredient_Recipe_LinkController : Controller
    {
        private ShoppingContext db = new ShoppingContext();

        // GET: Ingredient_Recipe_Link
        public ActionResult Index()
        {
            return View(db.Ingredient_Recipe_Links.ToList());
        }

        // GET: Ingredient_Recipe_Link/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ingredient_Recipe_Link ingredient_Recipe_Link = db.Ingredient_Recipe_Links.Find(id);
            if (ingredient_Recipe_Link == null)
            {
                return HttpNotFound();
            }
            return View(ingredient_Recipe_Link);
        }

        // GET: Ingredient_Recipe_Link/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ingredient_Recipe_Link/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LinkId,RecipeId,IngredientId")] Ingredient_Recipe_Link ingredient_Recipe_Link)
        {
            if (ModelState.IsValid)
            {
                db.Ingredient_Recipe_Links.Add(ingredient_Recipe_Link);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ingredient_Recipe_Link);
        }

        // GET: Ingredient_Recipe_Link/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ingredient_Recipe_Link ingredient_Recipe_Link = db.Ingredient_Recipe_Links.Find(id);
            if (ingredient_Recipe_Link == null)
            {
                return HttpNotFound();
            }
            return View(ingredient_Recipe_Link);
        }

        // POST: Ingredient_Recipe_Link/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LinkId,RecipeId,IngredientId")] Ingredient_Recipe_Link ingredient_Recipe_Link)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ingredient_Recipe_Link).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ingredient_Recipe_Link);
        }

        // GET: Ingredient_Recipe_Link/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ingredient_Recipe_Link ingredient_Recipe_Link = db.Ingredient_Recipe_Links.Find(id);
            if (ingredient_Recipe_Link == null)
            {
                return HttpNotFound();
            }
            return View(ingredient_Recipe_Link);
        }

        // POST: Ingredient_Recipe_Link/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ingredient_Recipe_Link ingredient_Recipe_Link = db.Ingredient_Recipe_Links.Find(id);
            db.Ingredient_Recipe_Links.Remove(ingredient_Recipe_Link);
            db.SaveChanges();
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
