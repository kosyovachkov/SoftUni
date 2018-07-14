using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int page = 1)
        {

            var database = new BlogDbContext();

            var pageSize = 4;

            var articles = database.Articles.OrderByDescending(a => a.Id)
                .Include(a => a.Tags)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = page;

            return View(articles);

            
        }

        public ActionResult ListCategories()
        {
            using (var db = new BlogDbContext())
            {
                var categories = db.Categories
                    .Include(c => c.Articles)
                    .ToList();
                return View(categories);
            }

            
        }

        
    }
}