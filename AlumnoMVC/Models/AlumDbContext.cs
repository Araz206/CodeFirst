using Microsoft.EntityFrameworkCore;

namespace AlumnoMVC.Models
{
    public class AlumDbContext : DbContext
    {
        public AlumDbContext(DbContextOptions<AlumDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
