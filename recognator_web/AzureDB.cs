namespace recognator_web
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AzureDB : DbContext
    {
        public AzureDB()
            : base("name=AzureDBcontext")
        {
        }

        public virtual DbSet<License> License { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
