using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProdutos.Models
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
     
   
    }
}
