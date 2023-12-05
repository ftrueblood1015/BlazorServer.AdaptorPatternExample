using System.ComponentModel.DataAnnotations;

namespace BlazorServer.AdaptorPatternExample.Domain.Models
{
    public class Fruit: ExternalIdBaseModel
    {
        [Required]
        public string? Family {  get; set; }

        [Required]
        public string? Genus { get; set; }

        [Required]
        public string? Order { get; set; }

        [Required]
        public double? Carbohydrates { get; set; }

        [Required]
        public double? Protein { get; set; }

        [Required]
        public double? Fat { get; set; }

        [Required]
        public double? Calories { get; set; }

        [Required]
        public double? Sugar { get; set; }
    }
}
