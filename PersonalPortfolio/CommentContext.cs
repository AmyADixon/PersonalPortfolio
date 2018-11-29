namespace PersonalPortfolio {
    using PersonalPortfolio.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CommentContext : DbContext {
        // Your context has been configured to use a 'CommentContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PersonalPortfolio.CommentContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CommentContext' 
        // connection string in the application configuration file.
        public CommentContext()
            : base("name=CommentContext") {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
         public virtual DbSet<VisitorComments> Response { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}