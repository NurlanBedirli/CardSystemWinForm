using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.DBExtensions
{
  public static class Existansions
    {
        public static int PhoneByNumber(this BankDataContext context, string Phonenumber)
        {
           // List<int> registerPhones = new List<int>();
            //registerPhones = (from e in context.RegisterPhones
            //                 where e.NumberPhone == Phonenumber
            //                  select e.PersonId).ToList();
          int registerPhones =  context.RegisterPhones.Where(x => x.NumberPhone == Phonenumber).Select(x => x.PersonId).FirstOrDefault();
          return registerPhones;
        }



        public static bool PhoneByAbuneCode(this BankDataContext context, int Abunecode)
        {
            bool isfound = false;
            int registerPhones = context.InternetModels.Where(x => x.AbuneKodu == Abunecode).Select(x => x.Id).FirstOrDefault();
            if(registerPhones != 0)
            {
                isfound = true;
            }

             return isfound;
        }


    }




}
