using BlogTdsTecnologia.Models;
using BlogTdsTecnologia.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
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
            List<Post> posts = await _context.PostDao.Include(p => p.Autor).ToListAsync();
            //return View( posts.Find( p => p.PostId == 3) );

            //Usuario u = posts.Find(p => p.PostId == 3).Autor;

            //Debug.WriteLine("Usuario nome: "+u.Nome);
            PostsViewModel postsViewModel = new PostsViewModel()
            {
                Posts = posts
            };
            return View(postsViewModel);
        }
    }
}
