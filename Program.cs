using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace banksss
{
    class Program
    {
        static int selection()
        {
            Console.WriteLine("Main menu");
            Console.WriteLine("1 - Create account");
            Console.WriteLine("2 - Deposit");
            Console.WriteLine("3 - Withdraw");
            int choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }

        static void InsertMoney(Person person,Bank bank)
        {
            Console.WriteLine(person.id);
            //Console.WriteLine(bank.Persons[0]);
            Console.WriteLine(" CURRENT BALANCE - £{0}", person.value);
            Console.WriteLine("Please enter the sum you want to Deposit:");
            int deposit = Convert.ToInt32(Console.ReadLine());
            bank.DepositMoney(person,deposit,bank);
        }

        static void GetOutMoney(Person person, Bank bank)
        {
            //Console.WriteLine(bank.Persons[0]);
            Console.WriteLine(" CURRENT BALANCE - £{0}", person.value);
            Console.WriteLine("Please enter the sum you want to Withdraw:");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            bank.WithdrawMoney(person, withdraw, bank);
        }


        static void Main(string[] args)
        {
            Bank bank = new Bank();
            

            while (true)
            {
                int x = selection();

                // Creates account / obj and Adds it to a list 
                if (x == 1)
                {
                    // should do something about this
                    Random rnd = new Random();
                    int id = rnd.Next(0, 100);

                    int value = 100;


                    Console.WriteLine("Please enter your first name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter your age");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your ID is:" + "" + id);
                    bank.createAccount(name, age, value, id);

                }
                // Depot money
                else if (x == 2)
                {
                    Console.WriteLine("Please enter your ID to login");
                    int user_id = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        // Linq method filtering
                        var person = bank.Persons.Where(s => s.id == user_id).Single();
                        Console.WriteLine(person);
                        Console.WriteLine("LOGGED IN");
                        InsertMoney(person, bank);
                    }
                    catch(System.InvalidOperationException)
                    {
                        Console.WriteLine("ERROR: Can't find ID!");
                    }
                     
        
                }
                // Withdraw
                else if (x == 3)
                {
                    Console.WriteLine("Please enter your ID to login");
                    int user_id = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        // Linq method filtering

                        var person = bank.Persons.Where(s => s.id == user_id).Single();
                        Console.WriteLine(person);
                        Console.WriteLine("LOGGED IN");
                        GetOutMoney(person, bank);

                    }
                    catch (System.InvalidOperationException)
                    {
                        Console.WriteLine("ERROR: Can't find ID!");

                    }
                }


            }
        }
    }
}
