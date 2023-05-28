using Microsoft.EntityFrameworkCore;

namespace WebCRUDMVCSQLSERVER.Models
{
    public class Contexto : DbContext
    {
        //construtor
        public Contexto(DbContextOptions<Contexto> options):base(options)
        {



        }

        public DbSet<Produto> Produto { get; set; }
    }
}
