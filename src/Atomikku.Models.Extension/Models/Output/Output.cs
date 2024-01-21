namespace Atomikku.Models.Extension
{
    public class Output
    {
        public string Tittle { get; set; }
        public string SecondTittle { get; set; }
        public string? Description { get; set; }
        public string Author { get; set; }
        public string? ReleaseDate { get; set; }
        public string ImageUrl { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
}