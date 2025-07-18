using Hugoserver.Models;
using Microsoft.EntityFrameworkCore;

namespace Hugoserver.Data
{
    public class ApplicationDbContext : DbContext

    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

            : base(options)

        {

        }

        public DbSet<Rol> Rol { get; set; }

        public DbSet<Persona> Persona { get; set; }

    }

}
