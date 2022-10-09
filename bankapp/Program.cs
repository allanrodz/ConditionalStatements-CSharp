using System;

namespace bankapp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to NKP bank\n\n");

            // variables are here
            string username = "allanrodz";
            int password = 1234;
            double balance = 0;
            int command;
            double savingsacc = 0;
            int attempt = 0;





            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Please log into your account to cotinue.\n\n");
            Console.Write("Enter username: ");
            string username1 = Console.ReadLine().ToLower();

            if (username1 != username)

            {
                
                do
                {
                        
                        Console.WriteLine("Welcome to NKP bank\n\n");
                        Console.Write("Invalid username, please try again!\n\n");
                        Console.Write("Enter username: \n\n");
                        username1 = Console.ReadLine().ToLower();
                        Console.Clear();
                        attempt++;

                    
                } while (attempt <= 2);

            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AUTHENTICATION NEEDED\n\n");
            Console.WriteLine("Please enter your password now: ");
            int password1 = int.Parse(Console.ReadLine());

            if (password1 != password)

            {

                do
                {

                    Console.WriteLine("Welcome to NKP bank\n\n");
                    Console.Write("Invalid password, please try again!\n\n");
                    Console.Write("Enter password: \n\n");
                    password1 = int.Parse(Console.ReadLine());
                    Console.Clear();


                } while (password1 != password);



            }

            do

            {
                Console.Clear();
                Console.WriteLine("Welcome to NKP bank\n\n");
                Console.WriteLine("Welcome, {0}! You are now logged in. Your current balance is {1:0.00} euros.\n\n", username, balance);


                Console.WriteLine("******MENU*******\n\n");


                Console.WriteLine("1. Transfer money to another account\n");
                Console.WriteLine("2. Make a lodgement\n");
                Console.WriteLine("3. Show balance\n");
                Console.WriteLine("4. Transfer money from your current to your saving accounts\n");
                Console.WriteLine("5. Exit\n");
                Console.Write("\n\nPlease enter one of the options above: ");
                command = int.Parse(Console.ReadLine());



                if (command == 2)
                {
                    
                    string answer;
                    Console.Write("Your current balance is {0}. Enter amount of the lodgement you wish to make: \n", balance);
                    balance = double.Parse(Console.ReadLine());
                    do
                    {

                        Console.WriteLine("Do you confirm that the amount of the lodgement is {0:0.00}? Press YES or NO.\n", balance);
                        answer = Console.ReadLine();
                        if (answer == "yes")
                        {
                            Console.WriteLine("Your new balance is {0}.", balance);

                        }

                        else if (answer == "no")
                        {
                            Console.WriteLine("Enter the amount of the lodgement you wish to make: ");
                            balance = double.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Invalid option, please enter YES OR NO: ");
                            answer = Console.ReadLine();
                        }

                    } while (answer != "yes" || answer == "no");
                }

                if (command == 3)
                   
                {
                    string answer;
                    Console.WriteLine("What balance would you like to check? Current or Savings? Please enter C or S");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "c")
                    {
                        Console.WriteLine("You have {0} euros in your CURRENT account.", balance);
                       
                    }
                    else if (answer == "s")
                    {
                        Console.WriteLine("You have {0} euros in your SAVINGS account.", savingsacc);
                    }

                    else
                    {
                        Console.WriteLine("INVALID OPTION.");
                        
                    }

                    Console.WriteLine("Press enter to go back to main menu");
                    Console.ReadLine();
                }

                if (command == 1)
                {
                    
                    Console.WriteLine("Enter the amount you wish to transfer: ");
                    double amount = int.Parse(Console.ReadLine());
                    if (balance < amount)
                    {
                        Console.WriteLine("Insuficient funds. Your balance is {0} euros.", balance);
                        Console.WriteLine("Press enter to go back to main menu");
                        Console.ReadLine();

                    }

                    else if (balance > amount)
                    {
                        string iban;


                        Console.WriteLine("Are you sure you want to transfer {0} euros? Press YES or NO.", amount);
                        string answer = Console.ReadLine().ToLower();




                        if (answer == "yes")
                        {
                            Console.WriteLine("Please Enter the receiver's IBAN: ");
                            iban = Console.ReadLine();
                            Console.WriteLine("Enter receiver's NAME: ");
                            string nome = Console.ReadLine();
                            balance = balance - amount;
                            Console.WriteLine("Transaction completed! Your new balance is {0}. Press enter to go back to the main menu.", balance);
                            Console.ReadLine();

                        }

                        else 
                        {
                            Console.WriteLine("Press enter to go back to main menu");
                            Console.ReadLine();
                        }
                    }


                }
                if (command == 4)
                {
                    
                    Console.Write("Do you wish to transfer money to your SAVINGS ACCOUNT? Enter YES or NO.");
                    string answer1 = Console.ReadLine().ToLower();
                    double amount1 = 0;
                    
                    string answer;
                    
                    do
                    {
                        if (answer1 == "yes" && balance > amount1)
                        {
                            Console.Write("Enter amount you wish to transfer to your savings account: ");
                            amount1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Is the amount of {0} euros correct? Enter YES or NO.", amount1);
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes")
                            {
                                balance = balance - amount1;
                                savingsacc = amount1;

                                Console.WriteLine("Transaction completed. Your current balance is {0}.", balance);
                                Console.WriteLine("Press enter to go back to main menu");
                                Console.ReadLine();
                            }
                        }
                        else if (answer1 == "yes" && balance < amount1)
                        { 
                            Console.WriteLine("Insuficient funds. Your current balance is {0}.", balance);
                            Console.WriteLine("Press enter to go back to main menu");
                            Console.ReadLine();
                        }

                        else 
                        {
                            Console.WriteLine("No problem. Press enter to go back the the main menu.");
                            Console.ReadLine();

                        }
                  
                      
                            
                   
                    } while (balance < amount1);

                
                
                }

            } while (command != 5);




            Console.ReadLine();



        }
    }

}