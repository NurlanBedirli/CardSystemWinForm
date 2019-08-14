using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.ConfigClass
{
  public  class InternetConfig : EntityTypeConfiguration<InternetModel>
    {
        public InternetConfig()
        {
            this.ToTable("Internet", "bank");

            this.Property(x => x.AbuneKodu)
                 .HasColumnType("int")
                  .IsRequired();
        }
    }
}
