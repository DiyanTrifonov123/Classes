using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasChovek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Ivan";
            person.age = 17;
            Console.WriteLine($"{person.name} e na {person.age} godini!");
        }
    }
}
