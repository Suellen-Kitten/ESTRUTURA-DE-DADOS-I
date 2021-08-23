using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC4M_02
{
    public class Cat
    {
        public Cat(int age, string nome)
        {
            Age = age;
            Nome = nome;
        }
        public int Age { get; set; }
        public string Nome { get; set; }
        public void Mia()
        {
            Console.WriteLine($"{Nome} says: Meow.");
        }
    }
}
