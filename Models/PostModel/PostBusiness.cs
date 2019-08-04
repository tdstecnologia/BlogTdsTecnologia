using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTdsTecnologia.Models.PostModel
{

    public class PostBusiness
    {
        private readonly Persistencia _context;

        public PostBusiness(Persistencia context)
        {
            _context = context;
        }

        public async Task<int> CadastrarPost(Post post)
        {
            post.DataCriacao = DateTime.Now;
            _context.Add(post);
            int status = await _context.SaveChangesAsync();
            return status;
        }
    }
}
