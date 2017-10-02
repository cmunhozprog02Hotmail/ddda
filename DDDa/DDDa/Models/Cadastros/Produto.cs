using DDDa.Models.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDDa.Models.Cadastros
{
    public class Produto
    {
        [Key]
        public long? ProdutoId { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório!")]
        [MaxLength(200, ErrorMessage ="Este {0} só pode conter {1})")]
        public string Nome { get; set; }

        public long? CategoriaId { get; set; }

        public long? FabricanteId { get; set; }

        // Relação das tabelas n:n
        public virtual Fabricante Fabricante { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}