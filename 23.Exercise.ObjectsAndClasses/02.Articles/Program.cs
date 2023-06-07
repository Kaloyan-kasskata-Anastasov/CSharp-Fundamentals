internal class Program
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        private string Title { get; set; }

        private string Content { get; set; }
        
        private string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    static void Main()
    {
        string[] articleArguments = Console.ReadLine().Split(", ");
        string title = articleArguments[0];
        string content = articleArguments[1];
        string author = articleArguments[2];

        Article article = new Article(title, content, author);

        int commandsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandsCount; i++)
        {
            string[] commands = Console.ReadLine().Split(": ");

            switch (commands[0])
            {
                case "Edit":
                    string newContent = commands[1];
                    article.Edit(newContent);
                    break;
                case "ChangeAuthor":
                    string newAuthor = commands[1];
                    article.ChangeAuthor(newAuthor);
                    break;
                case "Rename":
                    string newTitle = commands[1];
                    article.Rename(newTitle);
                    break;
            }
        }

        Console.WriteLine(article.ToString());
    }
}
