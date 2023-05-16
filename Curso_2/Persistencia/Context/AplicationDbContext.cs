using Curso_2.Dominio.Models;
using Microsoft.EntityFrameworkCore;

namespace Curso_2.Persistencia.Context
{
    public class AplicationDbContext:DbContext
    {
        public DbSet<Estudiante> Estudiante { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
