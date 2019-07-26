namespace healthscan_BE.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Required]
        [StringLength(100)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; internal set; }

        [Required]
        [JsonProperty(PropertyName = "barcodeId")]
        public int BarcodeNumber { get; internal set; }

        [Key]
        [Required]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; internal set; }

        [Required]
        [JsonProperty(PropertyName = "listIngredients")]
        public IList<Ingredient> ListIngredients { get; internal set; }
    }
}
