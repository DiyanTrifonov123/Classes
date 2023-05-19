using DefiniraneNaKlasChovek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiStariyaChlenNaFamiliyata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split().ToArray();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name,age);
                family.AddMember(person);
            }

            Person oldestMember = family.OldestMember();
            Console.WriteLine($"{oldestMember.name} {oldestMember.age}");
        }
    }
}
