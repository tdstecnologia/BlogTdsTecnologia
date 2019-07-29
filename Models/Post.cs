using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTdsTecnologia.Models
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
    }
}
