using BankLogin.ModelMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.Model
{
  public  class Repayment
    {
        public Repayment()
        {
            AddMessages = new List<AddMessages>();
        }
        public int Id { get; set; }
        public string RepaymentName { get; set; }
        public List<AddMessages> AddMessages { get; set; }
    }
}
