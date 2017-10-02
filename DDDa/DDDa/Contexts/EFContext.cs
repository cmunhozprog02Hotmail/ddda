using DDDa.Models.Cadastros;
using DDDa.Models.Tabelas;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DDDa.Contexts
{
    public class EFContext : DbContext
    {
        public EFContext() : base("DefaultConnection")
        {
                
        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Fabricante> Fabricantes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            base.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<DDDa.Models.Cadastros.Produto> Produtoes { get; set; }
    }
}