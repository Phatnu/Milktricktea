using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopeeShop_web.Data;
using ShopeeShop_web.Models;

namespace ShopeeShop_web.Controllers
{
    public class ItemController : Controller
    
    {
        private readonly ApplicationDbContext _db;
         public ItemController(ApplicationDbContext db)
         {
             _db = db;
         }

        public IActionResult index()
        {
        IEnumerable<Item> objItem = _db.Items;
            return View(objItem);
        }
        [HttpGet]//readonly//
          public IActionResult Create()
        {     
            return View();
        }
            [HttpPost]//actionna//
             public IActionResult Create(Item item)
        {     
            if(ModelState.IsValid)
            {
                _db.Items.Add(item);
                _db.SaveChanges();
                return RedirectToAction(nameof(index));
            }
            return View();
        }

        [HttpGet]//readonly//
          public IActionResult Edit(int id)
        {     
            var item = _db.Items.Find(id);
            return View(item);
        }

        [HttpPost]//actionna//
             public IActionResult Edit(Item item)
        {     
            if(ModelState.IsValid)
            {
                _db.Items.Update(item);
                _db.SaveChanges();
                return RedirectToAction(nameof(index));
            }
            return View();
        }


         [HttpGet]//readonly//
          public IActionResult Delete(int id)
        {     
            var item = _db.Items.Find(id);
            return View(item);
        }
        [HttpPost]//actionna//
        [ActionName("Delete")]
             public IActionResult DeletePost(int id)
        {     
                   var item = _db.Items.Find(id);
                   if(item == null)
                   {
                       return NotFound();
                   }

                _db.Items.Remove(item);
                _db.SaveChanges();
                return RedirectToAction(nameof(index));
        }

    }
}