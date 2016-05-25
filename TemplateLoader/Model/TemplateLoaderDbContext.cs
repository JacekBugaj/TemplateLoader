using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateLoader.Model
{
    class TemplateLoaderDbContext : DbContext
    {
        public TemplateLoaderDbContext() : base("TLoader")
        {
            Database.SetInitializer<TemplateLoaderDbContext>(new TemplateLoaderDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Mail> Mails { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<SiteOwner> SiteOwners { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
