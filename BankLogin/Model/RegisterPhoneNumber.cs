using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.Model
{
   public class RegisterPhoneNumber
    {
        public int Id { get; set; }
        public string NumberPhone { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
