namespace VelvetRoom.Views.Shared
{
    public class FortuneTeller
    {
        public FortuneTeller(string name, string desicription, string image) { this.name = name; this.desicription = desicription; this.image = image; }
        string name { set; get; }
        string desicription { set; get; }
        string image { set; get; }
    }
}
