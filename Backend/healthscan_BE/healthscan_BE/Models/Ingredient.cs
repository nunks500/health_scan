namespace healthscan_BE.Models
{
    using healthscan_BE.Enums;
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;

    public class Ingredient
    {
        [Key]
        [Required]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        [Required]
        [StringLength(100)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; internal set; }

        [Required]
        [JsonProperty(PropertyName = "ToxicityLevel")]
        public ToxicityLevels ToxicityLevel { get; internal set; }
    }
}