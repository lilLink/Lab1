using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private System.DateTime _birthday;

        public Person(string firstName, string lastName, DateTime birthday)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthday = birthday;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime Birthday { get => _birthday; set => _birthday = value; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Birthday.ToLongDateString();
        }

        public virtual string ToShortString()
        {
            return LastName + " " + FirstName;
        }
    }
}
