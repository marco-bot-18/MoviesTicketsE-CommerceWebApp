using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [Required (ErrorMessage ="Profile Picture is Require")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength (50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 to 50 characters")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }
        [Required(ErrorMessage = "Bio is Require")]

        // Relationships of the Data
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
