using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace And.Eticaret.UI.Web.Models.Sınıflar
{
    public class Context:DbContext
    {
       public Context() {

        
        }
        public DbSet<User> Users { get; set; }

        public DbSet<UserAddress> Addresses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<Basket> Baskets { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderProducts> OrderProducts { get; set; }

        public DbSet<OrderPayment> OrderPayments { get; set; }

        public DbSet<KargoBilgileri> KargoBilgileris { get; set; }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<IndirimKuponları> IndirimKuponlars { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }








    }
}