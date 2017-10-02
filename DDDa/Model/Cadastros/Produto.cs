
using Modelo.DDDa.Tabelas;
using System.ComponentModel.DataAnnotations;

namespace Modelo.DDDa.Cadastros
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