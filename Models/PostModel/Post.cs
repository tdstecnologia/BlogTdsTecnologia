using BlogTdsTecnologia.Models.UsuarioModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogTdsTecnologia.Models.PostModel
{

    [Table("tb01_post")]
    public class Post
    {
        [Key]
        [Column("id")]
        public int PostId { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("resumo")]
        public string Resumo { get; set; }

        [Column("texto")]
        public string Texto { get; set; }

        [Column("data_criacao")]
        public DateTime DataCriacao { get; set; }

        [Column("autor")]
        public int AutorId { get; set; }

        public Usuario Autor { get; set; }
    }
}
