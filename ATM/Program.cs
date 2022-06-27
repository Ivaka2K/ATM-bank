using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            void Print()
            {
                Console.WriteLine("Chose one of these options: ");
                Console.WriteLine("1.Deposit: ");
                Console.WriteLine("2.Withdraw: ");
                Console.WriteLine("3.ShowBalance: ");
                Console.WriteLine("4.Exit: ");
            }
            void Deposit (Card User)
            {
                Console.WriteLine("How much do you want to deposit ");
                double deposit=double.Parse(Console.ReadLine());
                User.setCardBalance(deposit);
                Console.WriteLine("Thank you for your deposit!"+User.getBalance());            
            }
            void Withdraw(Card User)
            {
                Console.WriteLine("How much do you want to withdraw? ");
                double withdraw=double.Parse(Console.ReadLine());
                if (User.getBalance() > withdraw)
                {
                    Console.WriteLine("Not enough money! ");
                }
                else
                { 
                    User.setCardBalance(User.getBalance()-withdraw);
                    Console.WriteLine("You successful withdraw money! ");
                }
            }
            void ShowBalance(Card User)
            {
                Console.WriteLine("Your balance is: "+User.getBalance());
            }
            List<Card> cards = new List<Card>();
            cards.Add(new Card("6414567893534567", 9959, 160.1, "Pesho", "Jelev"));
            cards.Add(new Card("5212567591232356", 8421, 260.5, "Gosho", "Ivanov"));
            cards.Add(new Card("9674354671232356", 1674, 260.5, "Tenko", "Stanev"));
            cards.Add(new Card("7509156591232356", 1205, 260.5, "Jeko", "Dimitrov"));

            Console.WriteLine("Please enter your card! ");
            string debitCard = "";
            Card user;
            while (true)
            {
                try
                {
                    debitCard = Console.ReadLine();
                    user = cards.FirstOrDefault(a => debitCard==debitCard);
                    if (user!=null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please try again! ");
                    }
                }
                catch
                {
                    Console.WriteLine("Please try again! ");
                }
                
            }
            Console.WriteLine("Enter your pin: ");
            int pincode = 0;
            while (true)
            {
                try
                {
                    pincode=int.Parse(Console.ReadLine());
                    if (user.getPinCode()==pincode)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect pin! ");
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect pin! ");
                }
            }
            Console.WriteLine("Welcome"+user.getFirstName());
            int option = 0;
            do
            {
                Print();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                {
                    if (option == 1)
                    {
                        Deposit(user);
                    }
                    else if (option == 2)
                    {
                        Withdraw(user);
                    }
                    else if (option == 3)
                    {
                        ShowBalance(user);
                    }
                    else if (option == 4)
                    {
                        break;
                    }
                    else 
                    {
                        option = 0;
                    }
                }
            } while (option!=4);
            {
                Console.WriteLine("Have a nice day!!!");
            }

            
            
        }
    }
}
