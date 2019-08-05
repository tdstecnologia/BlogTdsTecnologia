using BlogTdsTecnologia.Models.PostModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogTdsTecnologia.Models.UsuarioModel
{
    [Table("tb02_usuario")]
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int UsuarioId { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "O campo e-mail não contém um formato de e-mail válido")]
        [Column("email")]
        public string Email { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Column("ativo")]
        public bool Ativo { get; set; }

        [Column("data_criacao")]
        public DateTime DataCriacao { get; set; }

        [Column("data_ativacao")]
        public DateTime DataAtivacao { get; set; }

        [InverseProperty("Autor")]
        public List<Post> Posts { get; set; }
    }
}
