using BankLogin.Model;
using BankLogin.ModelMessage;
using BankLogin.SessionDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.DataBasaQuery
{
   public  class DBQuery
    {
        public  List<CardModel> GettAllCardById(int id)
        {
            List<CardModel> vs = new List<CardModel>();
            using (BankDataContext context = new BankDataContext())
            {
                //vs = (from e in context.People
                //      join pp in context.Cards
                //       on e.Id equals pp.PersonId
                //       where e.Id == id
                //      select new CardModel
                //      {
                //          Id = pp.Id,
                //          Name = e.Name,
                //          Surname = e.Surname,
                //          CardName = pp.CardName,
                //          CardType = pp.CardType,
                //          CardNumber = pp.CardNumber,
                //          ExpireDeath = pp.ExpireDeath,
                //          CVC = pp.CVC
                //      }).ToList();

                vs = context.Cards.Join(context.People, x => x.PersonId, y => y.Id, (x, y) => new CardModel
                {
                    Id = x.Id,
                    Name = y.Name,
                    Surname = y.Surname,
                    CardName = x.CardName,
                    CardType = x.CardType,
                    CardNumber = x.CardNumber,
                    ExpireDeath = x.ExpireDeath,
                    CVC = x.CVC,
                    Balance = x.Balance,
                    PersonId = x.PersonId
                }).Where(x => x.PersonId == id).ToList();
            }
            return vs;
        }


        public void AddBalance(List<CardModel> cards)
        {
            using (BankDataContext context = new BankDataContext())
            {
                decimal bl = cards.Select(y => y.Balance).FirstOrDefault();
                int id = cards.Select(y => y.Id).FirstOrDefault();
                var ss = context.Cards.Where(x => x.Id == id).ToList().First();
                ss.Balance = bl;
                context.SaveChanges();
            }
        }

        public void InsertMessage(string message,List<CardModel> cards,string repaymentName)
        {
            using (BankDataContext context = new BankDataContext())
            {
                int id = context.Repayments.Where(x=> x.RepaymentName == repaymentName).Select(x => x.Id).FirstOrDefault();
                context.AddMessages.Add(new AddMessages
                {
                    UserMessage = message,
                    PersonId = cards.Select(x => x.PersonId).FirstOrDefault(),
                    RepaymentId = id
                });
                context.SaveChanges();
            }
        }

        public List<Person> ByEmailUser(string email)
        {
            List<Person> users = new List<Person>();
            BankDataContext context = new BankDataContext();
            users =  context.People.Where(x => x.Email == email).ToList();
            return users;
        }
    }
}
