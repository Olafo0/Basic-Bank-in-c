using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banksss
{
    public class Person
    {

        Random rnd = new Random();


        public string name;
        public int age;
        public int value;
        public int id;



        public Person(string name, int age, int value, int id)
        {
            this.name = name;
            this.age = age;
            this.value = value;
            this.id = id;
        }
    }
}
