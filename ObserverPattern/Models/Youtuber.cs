namespace ObserverPattern.Models
{
    public class Youtuber
    {
        public List<Viewer> Subscriber { get; set; }
        public string Name { get; set; }
        public Youtuber()
        {
            Subscriber = new List<Viewer>();
            Name = string.Empty;
        }
        public void Subscribe(Viewer viewer)
        {
            Subscriber.Add(viewer);
        }
        public void Unsubscribe(Viewer viewer)
        {
            Subscriber.Remove(viewer);
        }
        public void Upload(Video video)
        {
            for (int i = 0; i < Subscriber.Count; i++)
            {
                Viewer.Notify(video, this);
            }
        }
    }
}