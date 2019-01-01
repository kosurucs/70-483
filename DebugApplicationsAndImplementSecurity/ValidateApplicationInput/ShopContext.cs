using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugApplicationsAndImplementSecurity.ValidateApplicationInput
{
    public class ShopContext : DbContext
    {
        public IDbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasRequired(bm => bm.BillingAddress)
            .WithMany().WillCascadeOnDelete(false);
        }
    }
}
