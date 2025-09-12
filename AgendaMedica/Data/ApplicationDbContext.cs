using AgendaMedica.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgendaMedica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Cada model que fazer colocar aqui em DbSet

        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Medico> Medico { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Especialidade>().ToTable("Especialidades");
            builder.Entity<Agenda>().ToTable("Agenda");
            builder.Entity<Paciente>().ToTable("Paciente");
            builder.Entity<Medico>().ToTable("Medico");
        }
    }
}
