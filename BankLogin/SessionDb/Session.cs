using BankLogin.DataBasaQuery;
using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.SessionDb
{
   public  class Session
    {
        public static List<CardModel> model { get; set; }
        public static List<CardModel> model1 { get; set; }
        public static List<Person> People { get; set; } 
    }
}
