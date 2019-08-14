using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.Model
{
  public  class Card
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public string CardHolder { get; set; }
        public string CardType { get; set; }
        [RegularExpression(@"\d{4}-\d{4}-\d{4}")]
        [MaxLength(14)]
        public string CardNumber { get; set; }
        public int CVC { get; set; }
        public decimal Balance { get; set; }
        public DateTime ExpireDeath { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
   
}
