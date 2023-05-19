using DefiniraneNaKlasChovek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            People people = new People();

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split().ToArray();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person person = new Person(name, age);
                people.AddMember(person);
            }
            people.Print();
        }
    }
}
