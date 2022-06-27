using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CardHolder
    {
        string firsName { get; set; }
        string lastName { get; set; }
        public CardHolder(string firsName, string lastName)
        {
            this.firsName = firsName;
            this.lastName = lastName;
        }
        
        public string getFirstName()
        {
            return firsName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public void setFirstName(string FirstName)
        {
            firsName = FirstName;
        }
        public void setLastName (string LastName)
        {
            lastName = LastName;
        }
    }
}
