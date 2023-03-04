using ObserverPattern.Models;

namespace ObserverPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Youtuber youtuber = new() { Name = "Jack" };

            youtuber.Subscribe(new Viewer());
            youtuber.Subscribe(new Viewer());
            youtuber.Subscribe(new Viewer());

            youtuber.Upload(new Video() { Name = "Observer pattern tutorial" });
        }
    }
}

