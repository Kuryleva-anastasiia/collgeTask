using System;

namespace Films
{
    [Serializable]
    public class Film
    {
        public string name { get; set; }
        public string year { get; set; }
        public string director { get; set; }
        public string country { get; set; }

        public Film(string name, string year, string director, string country)
        {
            this.name = name;
            this.year = year;
            this.director = director;
            this.country = country;
        }

        public string GetData()
        {
            return name + ", year " + year + ", director " + director + ", country " + country;
        }
    }
}
