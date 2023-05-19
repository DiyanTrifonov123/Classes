using DefiniraneNaKlasChovek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiStariyaChlenNaFamiliyata
{
    public class Family
    {
        public List<Person> Members { get; set; }

        public Family()
        {
            this.Members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }

        public Person OldestMember()
        {
            return this.Members.OrderByDescending(x => x.age).First();
        }
    }
}
