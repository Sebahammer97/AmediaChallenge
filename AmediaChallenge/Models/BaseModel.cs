using System.ComponentModel.DataAnnotations;

namespace AmediaChallenge.Models
{
    public class BaseModel
    {
        [Required]
        public bool is_active { get; set; }
    }
}
