﻿using Blog.Models;
using System;
using System.Collections.Generic;
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

            var articles = database.Articles.OrderByDescending(a => a.Date).Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.CurrentPage = page;

            return View(articles);

            
        }

        
    }
}