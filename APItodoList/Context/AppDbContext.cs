using APItodoList.Model;
using Microsoft.EntityFrameworkCore;

namespace APItodoList.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ItensListaModel> itensLista { get; set; }
    }
}
