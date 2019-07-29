using BlogTdsTecnologia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTdsTecnologia.Controllers
{
    public class HomeController : Controller
    {
        private readonly Persistencia _context;

        public HomeController(Persistencia context)
        {
            _context = context;
        }

        public IActionResult Index2()
        {
            var posts = _context.PostDao.FromSql("SELECT * FROM tb01_post").ToList();
            return View(posts);
        }

        public async Task<IActionResult> Index()
        {
            List<Post> posts = await _context.PostDao.ToListAsync();
            //return View( posts.Find( p => p.PostId == 3) );
            return View(posts);
        }
    }
}
