using System;
using System.Collections.Generic;

namespace Lab4_Stories
{
    public class StoryCollection
    {
        public List<Story> Stories { get; set; }

        public StoryCollection(params Story[] stories)
        {
            Stories = new List<Story>(stories);
        }

        public void Print()
        {
            Console.WriteLine("Список оповідань:");
            foreach (var story in Stories)
            {
                story.Print();
                Console.WriteLine(new string('-', 40));
            }
        }

        public List<Story> FindStoriesByAuthor(string author)
        {
            var foundStories = new List<Story>();
            if (author == null)
            {
                return foundStories;
            }

            foreach (var story in Stories)
            {
                if (story.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
                {
                    foundStories.Add(story);
                }
            }
            return foundStories;
        }
    }
}
