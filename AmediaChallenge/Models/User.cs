using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmediaChallenge.Models
{
    [Table("User")]
    public class User : BaseModel
    {
        [Key]
        public int id_user { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string surname { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public int id_userType { get; set; }
        public virtual UserType userType { get; set; }
        
    }
}
