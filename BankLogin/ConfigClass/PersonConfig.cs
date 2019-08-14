using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.ConfigClass
{
   public class PersonConfig : EntityTypeConfiguration<Person>
    {
         public PersonConfig()
        {
            this.ToTable("People", "bank");

            HasKey(x => x.Id);

            HasMany(x => x.registerPhoneNumbers)
                 .WithRequired(x => x.Person)
                     .HasForeignKey(x => x.PersonId);


            HasMany(x => x.Cards)
                            .WithRequired(x => x.Person);
        }
    }
}
