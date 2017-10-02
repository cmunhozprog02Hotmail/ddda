using DDDa.Models.Cadastros;
using System.Collections.Generic;

namespace DDDa.Models.Tabelas
{
    public class Categoria
    {
        public long? CategoriaId { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}