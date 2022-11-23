using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmediaChallenge.Models
{
    [Table("UserType")]
    public class UserType : BaseModel
    {
        [Key]
        public int id_userType { get; set; }
        [Required]
        public string name { get; set; }
    }
}
