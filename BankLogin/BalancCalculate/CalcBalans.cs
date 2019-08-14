using BankLogin.CardMode;
using BankLogin.DataBasaQuery;
using BankLogin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.BalancCalculate
{
   public class CalcBalans
    {
        public void Calc(decimal money)
        {
            CardModel card1 = new CardModel();
            var card = SessionDb.Session.model1;
            var balans = card.Select(x => x.Balance).FirstOrDefault();
            decimal result = Convert.ToDecimal(balans) - money;
            foreach(var elm in card)
            {
                elm.Balance = result;
            }
            DBQuery dBQuery = new DBQuery();
            dBQuery.AddBalance(card);
            SessionDb.Session.model1 = card;

            CardMode.CardMode internetodeme = CardMode.CardMode.InternetOdeme;
            ValidEnum @enum = new ValidEnum();
            string str = @enum.IsEnumValid(internetodeme, money, result);
            dBQuery.InsertMessage(str, card, "InternetOdeme");
        }

        public void BlanceCount(decimal money)
        {
            var card = SessionDb.Session.model1;
            decimal balans = card.Select(x => x.Balance).FirstOrDefault();
            decimal result = balans + money;
            foreach (var elm in card)
            {
                elm.Balance = result;
            }
            DBQuery dBQuery = new DBQuery();
            dBQuery.AddBalance(card);
            SessionDb.Session.model1 = card;
            CardMode.CardMode BalancArtirma = CardMode.CardMode.BalancArtirma;
            ValidEnum @enum = new ValidEnum();
            string str = @enum.IsEnumValid(BalancArtirma, money, result);
            dBQuery.InsertMessage(str, card, "BalancArtirma");
        }
    }
}
