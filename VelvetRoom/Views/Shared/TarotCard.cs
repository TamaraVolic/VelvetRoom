namespace VelvetRoom.Views.Shared
{
    public class TarotCard
    {
        public TarotCard(string title, string desicription, string image) { this.title = title; this.desicription = desicription; this.image = image; }
        string title { set; get; }
        string desicription { set; get; }
        string image { set; get; }

    }
}
