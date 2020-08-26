using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab9B.Models;

namespace Lab9B.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        //{
        //    Dictionary<string, Product> products = new Dictionary<string, Product> 
        //    {
        //        { "Kayak", new Product { Name = "Kayak", Price = 275M } },
        //        { "Lifejacket", new Product{ Name = "Lifejacket", Price = 48.95M } }
        //    };
        //    return View("Index", products.Keys);
        //}
        public ViewResult Index()
        {
            return View(new string[] { "Cody", "Thomas", "Chester" });
        }
    }
}
