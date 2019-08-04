using BlogTdsTecnologia.Models.PostModel;
using BlogTdsTecnologia.Models.UsuarioModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTdsTecnologia.Models
{
    public class Persistencia : DbContext
    {
        public Persistencia(DbContextOptions<Persistencia> opcoes) : base(opcoes)
        {
        }

        public DbSet<Post> PostDao { get; set; }

        public DbSet<Usuario> UsuarioDao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Autor)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.AutorId);
        }
    }
}
