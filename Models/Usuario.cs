using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTdsTecnologia.Models
{
    [Table("tb02_usuario")]
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int UsuarioId { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

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
    }
}
