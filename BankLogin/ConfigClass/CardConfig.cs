using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.ConfigClass
{
  public  class CardConfig : EntityTypeConfiguration<Card>
    {
         public CardConfig()
        {
            ToTable("Card", "bank");

            HasKey(x => x.Id);

            Property(x => x.Balance)
                 .HasPrecision(8, 2)
                  .IsOptional();

            Property(x => x.ExpireDeath)
              .HasColumnType("smalldatetime")
               .IsRequired();
        }
    }
}
