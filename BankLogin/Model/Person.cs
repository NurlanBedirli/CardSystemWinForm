using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.Model
{
    public class Person
    {

        public Person()
        {
            registerPhoneNumbers = new List<RegisterPhoneNumber>();
            Cards = new List<Card>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public List<RegisterPhoneNumber> registerPhoneNumbers { get; set; }
        public List<Card> Cards { get; set; }
    }
}
