using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Card:CardHolder
    {
        string cardNumber { get; set; }
        int pinCode { get; set; }
        double cardBalance { get; set; }
        public Card(string cardNumber, int pinCode, double cardBalance,string firstName,string lastName)
            :base(firstName, lastName)
        {
            this.cardNumber = cardNumber;
            this.pinCode= pinCode;
            this.cardBalance = cardBalance;
        }
        
        public string getCardNumber()
        {
            return cardNumber;
        }
        public int getPinCode()
        {
            return pinCode;
        }
        public double getBalance()
        {
            return cardBalance;
        }
        public void setCardNum(string newCardNum)
        {
            cardNumber = newCardNum;
        }
        public void setPinCode(int newPinCode)
        {
            pinCode = newPinCode;
        }
        public void setCardBalance(double balanceFromCard)
        {
            cardBalance = balanceFromCard;
        }
    }
}
