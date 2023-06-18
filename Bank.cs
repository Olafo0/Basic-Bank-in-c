using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banksss
{
    class Bank  
    {
        public List<Person> Persons { get; set; } = new List<Person>();
        public void createAccount(string name, int age, int value, int id)
        {
            Person user = new Person(name, age, value, id);
            Persons.Add(user);

        }

        public void DepositMoney(Person person,int deposit,Bank bank)
        {
            person.value += deposit;
            Console.WriteLine("UPDATED BALANCE - £{0}", person.value);
        }
        public void WithdrawMoney(Person person, int withdraw, Bank bank)
        {
            if (withdraw >= 1)
            {
                if (person.value <= 0)
                {
                    Console.WriteLine("You can't withdraw any cash right now beacuse you're broke!");
                }
            }
            else
            {
                person.value -= withdraw;
                Console.WriteLine("UPDATED BALANCE - £{0}", person.value);
            }
        }
    }
}
