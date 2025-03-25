// Models/ChampionMastery.cs
namespace FakerChampionMastery.Models
{
    public class ChampionMastery
    {
        public int Id { get; set; }
        public string KoreanName { get; set; }
        public string EnglishName { get; set; }
        public double UsagePercentage { get; set; }
        public string ImageUrl { get; set; }
    }
}