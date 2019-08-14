using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.ConfigClass
{
  public  class PhoneNumberConfig : EntityTypeConfiguration<RegisterPhoneNumber>
    {
         public PhoneNumberConfig()
        {
            ToTable("PhoneNumber", "bank");

            HasKey(x => x.Id);
        }
    }
}
