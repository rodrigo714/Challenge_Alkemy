using EntityFramework.DynamicFilters;
using System.Data.Entity;

namespace Challenge_Alkemy.Data
{
    public class Challenge_AlkemyContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Challenge_AlkemyContext() : base("name=Challenge_AlkemyContext")
        {
        }

        public DbSet<Models.Categoria> Categorias { get; set; }
        public DbSet<Models.Posts> Posts { get; set; }

        private void FiltroSD(ref DbModelBuilder modelBuilder)
        {
            modelBuilder.Filter("IsDeleted", (ISoftDeleted d) => d.IsDeleted, false);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // ...
            FiltroSD(ref modelBuilder);
        }
    }
}
