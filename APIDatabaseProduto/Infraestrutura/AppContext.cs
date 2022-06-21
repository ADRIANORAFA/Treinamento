using APIDatabaseProduto.Models;
using Microsoft.EntityFrameworkCore;

namespace APIDatabaseProduto.Infraestrutura
{
    public class AppContext : DbContext
    {

        public AppContext(DbContextOptions<AppContext> BuilderOptions)
            : base(BuilderOptions)
        {

        }

        public DbSet <Produto > Produto { get; set; }
         public DbSet <Caracteristica> Caracteristica { get; set; }

    }
}
