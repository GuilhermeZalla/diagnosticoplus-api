using APITCC2021.Models;
using Microsoft.EntityFrameworkCore;

namespace APITCC2021.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Doenca> Doencas { get; set; }
        public DbSet<Sintoma> Sintomas { get; set; }
        public DbSet<AssociacaoDoencaSintoma> AssociacaoDoencasSintomas { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
    }
}