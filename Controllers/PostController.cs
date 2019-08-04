using BlogTdsTecnologia.Models;
using BlogTdsTecnologia.Models.PostModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BlogTdsTecnologia.Controllers
{
    public class PostController : Controller
    {
        private readonly PostBusiness _postBusiness;

        public PostController(Persistencia context)
        {
            _postBusiness = new PostBusiness(context);
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Novo(Post post)
        {
            if (ModelState.IsValid)
            {
                await _postBusiness.CadastrarPost(post);
                return RedirectToAction("Novo");
            }
            return View(post);
        }


    }
}
