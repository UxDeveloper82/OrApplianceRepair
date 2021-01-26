using Blog.Data;
using Blog.Data.FileManager;
using Blog.Data.Repository;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() 
        {
            return View(); 
        }

        public ActionResult About() 
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }
    }
}
