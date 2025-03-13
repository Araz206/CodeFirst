using Microsoft.EntityFrameworkCore;

namespace EmpleadoMVC.Models
{
    public class EmpleDbContext : DbContext
    {
        public EmpleDbContext(DbContextOptions<EmpleDbContext> options) : base(options) { }
        public DbSet<Empleado> Empleados { get; set; }

    }
}
