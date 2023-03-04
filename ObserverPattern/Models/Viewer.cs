namespace ObserverPattern.Models
{
    public class Viewer
    {
        public static void Notify(Video video, Youtuber youtuber)
        {
            Console.WriteLine("A video: '" + video.Name + "' was uploaded by " + youtuber.Name);
        }
    }
}