using System;

namespace Imi.Project.Blazor.Models
{
    public class AnimalItem
    {
        public int Id { get; set; }
        public string NameFamily { get; set; }
        public string NameDutch { get; set; }
        public Uri Image { get; set; }
        public InputSelectItem Types { get; set; }
        public int TypeId { get; set; }
        public InputSelectItem Diets { get; set; }
        public int DietId { get; set; }
        public InputSelectItem Continents { get; set; }
        public int ContinentId { get; set; }
        public InputSelectItem Socials { get; set; }
        public int SocialId { get; set; }
        public InputSelectItem Breedings { get; set; }
        public int BreedingId { get; set; }
        public decimal minTemp { get; set; }
        public decimal maxTemp { get; set; }
        public decimal minPh { get; set; }
        public decimal maxPh { get; set; }
        public decimal minGh { get; set; }
        public decimal maxGh { get; set; }

    }
}
