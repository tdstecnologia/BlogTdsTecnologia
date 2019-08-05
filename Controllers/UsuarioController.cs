using BlogTdsTecnologia.Models;
using BlogTdsTecnologia.Models.UsuarioModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BlogTdsTecnologia.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly UsuarioBusiness _usuarioBusiness;

        public UsuarioController(Persistencia context)
        {
            _usuarioBusiness = new UsuarioBusiness(context);
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Novo(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _usuarioBusiness.CadastrarUsuario(usuario);
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception e)
                {
                    return View();
                }
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View(usuario);
            }
            
        }

    }
}
