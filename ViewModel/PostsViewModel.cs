using BlogTdsTecnologia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTdsTecnologia.ViewModel
{
    public class PostsViewModel
    {
        public IEnumerable<Post> Posts { get; set; }

        public IEnumerable<Usuario> Usuarios { get; set; }

    }
}
