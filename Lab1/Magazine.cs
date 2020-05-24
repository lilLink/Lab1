using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Magazine
    {
        private string _nameMagazine;
        private Frequency _frequency;
        private DateTime _datePublished;
        private int _editionMagazine;
        private Article[] _listArticles;

        public string NameMagazine { get => _nameMagazine; set => _nameMagazine = value; }
        public Frequency FrequencyMagazine { get => _frequency; set => _frequency = value; }
        public DateTime DatePublished { get => _datePublished; set => _datePublished = value; }
        public int EditionMagazine { get => _editionMagazine; set => _editionMagazine = value; }
        public Article[] ListArticles { get => _listArticles; set => _listArticles = value; }

        public Magazine() { }
        public Magazine(string nameMagazine, Frequency frequency, DateTime datePublished, int editionMagazine)
        {
            _nameMagazine = nameMagazine;
            _frequency = frequency;
            _datePublished = datePublished;
            _editionMagazine = editionMagazine;
            _listArticles = new Article[20];
        }

        public double AvgRate
        {
            get
            {

                    if (_listArticles[0] == null)
                    return 0;

                return _listArticles
                    .Where(o => o != null)
                    .Average(o => o.Rate);
            }
        }

        public bool this[Frequency frequency]=>frequency==_frequency;

        
        public void AddArticles(params Article[] articles)
        {
            int lastIndex = this._listArticles
                .Where(o => o != null)
                .Count();

            articles.CopyTo(this._listArticles, lastIndex);
        }

        public override string ToString()
        {
            return _nameMagazine + " " + _frequency + " " + _datePublished + " " + _editionMagazine + " " + _listArticles;
        }

        public virtual string ToShortString() 
        {
            return _nameMagazine + " " + _frequency + " " + _datePublished + " " + _editionMagazine + " " + AvgRate;
        }
    }
}
