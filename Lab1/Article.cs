using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Article
    {
        private Person _author;
        private string _name;
        private double _rate;

        public Person Author { get => _author; set => _author = value; }
        public string Name { get => _name; set => _name = value; }
        public double Rate { get => _rate; set => _rate = value; }

        public Article() { }
        public Article(Person author, string name, double rate)
        {
            _author = author;
            _name = name;
            _rate = rate;
        }

        public override string ToString()
        {
            return Author + " " + Name + " " + Rate;
        }
    }
}
