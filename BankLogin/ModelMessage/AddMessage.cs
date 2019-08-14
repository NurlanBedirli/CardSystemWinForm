using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.ModelMessage
{
   public class AddMessages
    {
        public int Id { get; set; }
        public string UserMessage { get; set; }
        public int PersonId { get; set; }
        public int RepaymentId { get; set; }
    }
}
