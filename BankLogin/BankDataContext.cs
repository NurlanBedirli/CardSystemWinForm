using BankLogin.ConfigClass;
using BankLogin.Model;
using BankLogin.ModelMessage;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin
{
  public  class BankDataContext : DbContext
    {
        public BankDataContext() : base("Db") { }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<RegisterPhoneNumber> RegisterPhones { get; set; }
        public DbSet<InternetModel> InternetModels { get; set; }
        public DbSet<AddMessages> AddMessages { get; set; }
        public DbSet<Repayment> Repayments { get; set; }
        public DbSet<CardDefault> CardDefaults { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CardConfig());
            modelBuilder.Configurations.Add(new PersonConfig());
            modelBuilder.Configurations.Add(new PhoneNumberConfig());
            modelBuilder.Configurations.Add(new InternetConfig());
        }
    }
}
