using Microsoft.EntityFrameworkCore;
using Adm_Imoveis.Models;

namespace Adm_Imoveis.Data
{
    public class Context_db : DbContext
    {
        public Context_db(DbContextOptions<Context_db> options) : base(options) { }

        public DbSet<Imovel> DbSetImovel { get; set; }
        public DbSet<Pessoas> DbSetPessoa { get; set; }
        public DbSet<TipoPessoa> DbSetTipo { get; set; }
        public DbSet<Visita> DbSetVisita { get; set; }
        public DbSet<Adm_Imoveis.Models.Pessoas> Pessoas { get; set; }
        public DbSet<Adm_Imoveis.Models.TipoPessoa> TipoPessoa { get; set; }
        public DbSet<Adm_Imoveis.Models.Visita> Visita { get; set; }
    }
}
