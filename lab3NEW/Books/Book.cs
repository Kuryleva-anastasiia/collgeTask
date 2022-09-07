using System;

namespace Books
{
    [Serializable]
    public class Book
    {
        
        public string name { get; set; }
        public string year { get; set; }
        public string author { get; set; }
        public string pages { get; set; }

        public Book(string name, string year, string author, string pages)
        {
            this.name = name;
            this.year = year;
            this.author = author;
            this.pages = pages;
        }

        public string GetData()
        {
            return name + ", year " + year + ", author " + author + ", pages " + pages;
        }
    }
}
