using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OldestMember
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.People = new List<Person>(); //s gl bukva??
        }

        public List<Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }

        public void AddMember(Person member)
        {
            this.People.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldest = this.People.OrderByDescending(p=>p.Age).First();
            return oldest;
        }
    }
}
