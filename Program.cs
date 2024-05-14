using System;

namespace Lab4_Stories
{
    class Program
    {
        static void Main(string[] args)
        {
            StoryCollection collection = new StoryCollection(
                new Story("Захар Беркут", "Іван Франко", 1883, "Україна"),
                new Story("Кайдашева сім'я", "Іван Нечуй-Левицький", 1878, "Україна"),
                new Story("Тіні забутих предків", "Михайло Коцюбинський", 1911, "Україна"),
                new Story("Маленький принц", "Антуан де Сент-Екзюпері", 1943, "Франція"),
                new Story("Палата №6", "Антон Чехов", 1892, "Росія")
            );

            PrintHeader("Перелік оповідань");
            collection.Print();

            while (true)
            {
                PrintSeparator();
                Console.WriteLine("Введіть ім'я автора для пошуку (або 'вийти' для завершення):");
                string? author = Console.ReadLine();

                if (author != null && author.Equals("вийти", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Завершення програми.");
                    break;
                }

                if (!string.IsNullOrWhiteSpace(author))
                {
                    var foundStories = collection.FindStoriesByAuthor(author);

                    if (foundStories.Count > 0)
                    {
                        PrintHeader("Знайдені оповідання");
                        foreach (var story in foundStories)
                        {
                            story.Print();
                            PrintSeparator();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Оповідання вказаного автора не знайдено.");
                    }
                }
                else
                {
                    Console.WriteLine("Ви не ввели ім'я автора для пошуку.");
                }
            }
        }

        static void PrintHeader(string title)
        {
            Console.WriteLine(new string('=', 40));
            Console.WriteLine(title);
            Console.WriteLine(new string('=', 40));
        }

        static void PrintSeparator()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
