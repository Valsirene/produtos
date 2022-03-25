using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProdutos.Models
{
    public class Produtos
    {
        public int Id { get; set; }
  
        public string DescProduto { get; set; }
        public int IdCategoria  { get; set; }
        public Categoria categoria { get; set; }

      
    }
}
