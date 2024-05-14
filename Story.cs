using System;

namespace Lab4_Stories
{
    public class Story
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }

        public Story(string title, string author, int year, string country)
        {
            Title = title;
            Author = author;
            Year = year;
            Country = country;
        }

        public void Print()
        {
            Console.WriteLine($"Назва: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Рік написання: {Year}");
            Console.WriteLine($"Країна автора: {Country}");
        }
    }
}
