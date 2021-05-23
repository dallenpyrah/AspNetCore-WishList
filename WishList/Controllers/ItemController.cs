using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Item Item)
        {
            _context.Items.Add(Item);
            return View();
        }

        [HttpDelete]

        public IActionResult Delete(int Id)
        {
            var item = _context.Items.FirstOrDefault(item => item.Id == Id);
            _context.Items.Remove(item);
            return View();
        }
    }
}
