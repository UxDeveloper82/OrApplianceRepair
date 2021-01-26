using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class MyMessagesController : Controller
    {
        private AppDbContext _context;

        public MyMessagesController(AppDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: MyMessages
        [Authorize]
        public ActionResult Index()
        {
            var mymessages = _context.MyMessages.ToList();
            return View(mymessages);
        }

        public ActionResult New()
        {
            var viewModel = new MyMessagesViewModel();

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create(MyMessage mymessage)
        {
            _context.MyMessages.Add(mymessage);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}