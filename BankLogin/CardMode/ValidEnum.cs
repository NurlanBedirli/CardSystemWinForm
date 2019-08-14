using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.CardMode
{
 
  public  class ValidEnum
    {
        public string IsEnumValid(CardMode mode,decimal money,decimal result)
        {
            string str = "";
            if (CardMode.InternetOdeme == mode)
            {
               str =  $"Internet Odeme Xidmetinden Bu Tarixde {DateTime.Now} Balansizindan {money} Azn cixildi, Balansiniz {result} Azn teskil edir";
            }
            if(CardMode.BalancArtirma == mode)
            {
                str = $"Balanciniz Bu Tarixde {DateTime.Now}  {money} Azn artirildi, Balansiniz {result} Azn teskil edir";
            }
            return str;
        }
    }
}
