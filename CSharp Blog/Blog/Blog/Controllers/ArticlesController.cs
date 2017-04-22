using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Blog.Models;


namespace Blog.Controllers
{

    [ValidateInput(false)]

    public class ArticlesController : Controller
    {
        private BlogDbContext db = new BlogDbContext();

        public ActionResult All()
        {
            var articlesWithAuthors = db.Articles
                .Include(a => a.Author)
                .ToList();
            return View(articlesWithAuthors);
        }

        // GET: Articles
        public ActionResult List()
        {
            var articlesWithAuthors = db.Articles
                .Include(a => a.Author)
                .ToList();
            return View(articlesWithAuthors);
        }

        // GET: Articles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // GET: Articles/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Content, Image")] Article article)
        {
            if (ModelState.IsValid)
            {
                article.Author = db.Users
                    .FirstOrDefault(u => u.UserName == User.Identity.Name);



                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(article);
        }

        // GET: Articles/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);

            //if (!User.Identity.Name.Equals(article.Author.UserName) || !User.IsInRole("Administrators"))
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            //}

            if (article == null)
            {
                return HttpNotFound();
            }

            var authors = db.Users.ToList();
            ViewBag.Authors = authors;
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Content,Date,AuthorId")] Article article)
        {
            if (ModelState.IsValid)
            {
                
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(article);
        }

        // GET: Articles/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // POST: Articles/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article article = db.Articles.Find(id);

            if (!User.Identity.Name.Equals(article.Author.UserName) || !User.IsInRole("Administrators"))
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
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
