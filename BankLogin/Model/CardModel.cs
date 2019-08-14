using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.Model
{
  public  class CardModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public DateTime ExpireDeath { get; set; }
        public int CVC { get; set; }
        public decimal Balance { get; set; }
        public int PersonId { get; set; }
    }
}
