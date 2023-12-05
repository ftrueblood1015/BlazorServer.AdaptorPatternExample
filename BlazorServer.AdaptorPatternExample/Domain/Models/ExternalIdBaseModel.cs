using System.ComponentModel.DataAnnotations;

namespace BlazorServer.AdaptorPatternExample.Domain.Models
{
    public class ExternalIdBaseModel : BaseModel
    {
        [Required]
        public int ExternalId { get; set; }

        [Required]
        public DateTime? RquestedDate { get; set; }
    }
}
