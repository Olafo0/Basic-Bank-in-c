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

        public void DepositMoney(int i,int deposit,Bank bank)
        {
            bank.Persons[i].value += deposit;
        }
        public void WithdrawMoney(int i, int withdraw, Bank bank)
        {
            bank.Persons[i].value -= withdraw;
        }
    }
}
