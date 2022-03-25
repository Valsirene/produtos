using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProdutos.Models
{
    public class Categoria
    {

        public int Id { get; set; }
        public string DescCategoria { get; set; }
        public ICollection<Produtos> Produto { get; set; }
    }
}
