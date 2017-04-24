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
            var categories = db.Categories.ToList();

            var model = new ArticleViewModel();
            model.Categories = categories;

            return View(model);
        }

        // POST: Articles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticleViewModel model, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);


                var article = new Article(user.Id, model.Title, model.Content, model.Image, model.CategoryId);

                if (image != null)
                {
                    var allowedTypes = new[] { "image/jpg", "image/jpeg", "image/png", "image/gif" };
                    if (allowedTypes.Contains(image.ContentType))
                    {
                        var imagesPath = "/Content/Images";
                        var filename = image.FileName;

                        var uploadPath = imagesPath + filename;

                        var physicalPath = Server.MapPath(uploadPath);
                        image.SaveAs(physicalPath);

                        article.Image = uploadPath;

                    }
                }

                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(model);
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


            if (!User.IsInRole("Administrators") && !(article.Author != null && article.Author.UserName.Equals(User.Identity.Name)))
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            if (article == null)
            {
                return HttpNotFound();
            }

            var model = new ArticleViewModel();
            model.Id = article.Id;
            model.Title = article.Title;
            model.Content = article.Content;
            model.Image = article.Image;
            model.AuthorId = article.AuthorId;
            model.CategoryId = article.CatgoryId;
            model.Categories = db.Categories.OrderBy(c => c.Name).ToList();

            var authors = db.Users.ToList();
            ViewBag.Authors = authors;
            return View(model);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, ArticleViewModel model, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {

                var article = db.Articles.FirstOrDefault(a => a.Id == id);
                article.Title = model.Title;
                article.Content = model.Content;
                //article.Image = model.Image;
                article.AuthorId = model.AuthorId;
                article.CatgoryId = model.CategoryId;

                if (image != null)
                {
                    var allowedTypes = new[] { "image/jpg", "image/jpeg", "image/png", "image/gif" };
                    if (allowedTypes.Contains(image.ContentType))
                    {
                        var imagesPath = "/Content/Images";
                        var filename = image.FileName;

                        var uploadPath = imagesPath + filename;

                        var physicalPath = Server.MapPath(uploadPath);
                        image.SaveAs(physicalPath);

                        article.Image = uploadPath;

                    }
                }

                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        // GET: Articles/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.FirstOrDefault(a => a.Id == id);
            if (article == null)
            {
                return HttpNotFound();
            }

            if (!User.IsInRole("Administrators") && !(article.Author != null && article.Author.UserName.Equals(User.Identity.Name)))
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }
            return View(article);
        }

        // POST: Articles/Delete/5
        [Authorize]
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Article article = db.Articles.FirstOrDefault(a => a.Id == id);

            

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
