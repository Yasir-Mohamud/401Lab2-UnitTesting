using System;

namespace ATM
{
   public class Program
    {

       public static decimal balance = 300;

        public static void Main(string[] args)
        {
            UserInterface();
        }

        /// <summary>
        /// Starts application and runs methods
        /// </summary>

        public static void UserInterface() 
        {
            Console.WriteLine("Hi, Welcome to Code Bank");

            int userInput;

            do
            {
                Console.WriteLine(" Pick from below to get started");
                Console.WriteLine("1. Balance  2. Withdraw  3.Deposit  4.Done");
                userInput = Convert.ToInt32(Console.ReadLine());

               
                string userChoice = "yes";
                if (userInput == 1)
                {
                    Console.WriteLine($"Your current balance is {ViewBalance()}");
                    
                }
                if (userInput == 2)
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    decimal amount = int.Parse(Console.ReadLine());
                    decimal newBalance = Withdraw(amount);
                    if(newBalance >= 0)
                    {
                        Console.WriteLine($"Your new balance is {newBalance}");
                    }
                    else
                    {
                        Console.WriteLine($"Insufficient balance. Cannot withdraw amount : {amount} " +
                            $"from balance : {balance}");
                    }

                }

                if (userInput == 3)
                {
                    Console.WriteLine("How much do you want to deposit?");
                    decimal userAmount = int.Parse(Console.ReadLine());
                    decimal newBalance = Deposit(userAmount);
                    Console.WriteLine($"Your new balance is {newBalance}");
                }

                if (userInput == 4)
                {
                    break;
                }

                if (userChoice == "yes")
                {
                    Console.WriteLine("Do you want to continue and choose another option? yes or no?"); 
                    userChoice = Console.ReadLine();
                }
                if(userChoice == "no")
                {
                    break;
                }

            }
            while (userInput != 4);
            
         
            
                    Console.WriteLine("Have a great day");

        }

        /// <summary>
        /// Gets the balance of the user
        /// </summary>
        /// <returns>Balance</returns>
        public static decimal ViewBalance() 
        {
           
            return balance;
        }

        /// <summary>
        /// Takes in a parament and subtracts from the balance and return a new balance
        /// </summary>
        /// <param name="userAmount"></param>
        /// <returns>balance</returns>

        public static decimal Withdraw( decimal userAmount)
        {
            if (userAmount <= balance && userAmount > 0)
            {
                return balance -= userAmount;
            }
            else
            {
                return -1;
            }
           
        }

        /// <summary>
        /// Get input from user and adds it to the balance
        /// </summary>
        /// <param name="userAmount"></param>
        /// <returns></returns>
        public static decimal Deposit( decimal userAmount)
        {
            return balance += userAmount;
        }

    }
}
