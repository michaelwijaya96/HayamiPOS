namespace PosAsp
{
    using PosAsp.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        // Your context has been configured to use a 'Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PosAsp.Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Context' 
        // connection string in the application configuration file.
        public Context()
            : base("name=Context")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Models.Type>().Property(t => t.TypePrice).HasPrecision(23, 6);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Models.Type> Types { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<ProductHd> ProductHds { get; set; }
    }
}