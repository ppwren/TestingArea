using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TestingArea.Models;

namespace TestingArea.DAL
{
    public class TopicsContext : DbContext
    {
        public TopicsContext() : base(ConfigurationManager.ConnectionStrings["TestArea"].ToString())

        {
        }

        public TopicsContext(string connectionString)
            : base(connectionString)
        {

        }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Topic> Topics { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}