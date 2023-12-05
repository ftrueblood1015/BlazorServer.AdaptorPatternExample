using System.ComponentModel.DataAnnotations;

namespace BlazorServer.AdaptorPatternExample.Domain.Models
{
    public class BaseModel
    {
        [Required]
        public int? Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
