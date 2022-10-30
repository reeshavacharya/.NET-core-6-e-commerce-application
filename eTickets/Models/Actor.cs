using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display (Name ="Profile Pricture ")]
        [Required(ErrorMessage ="Profile Picture is Required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [StringLength (50, MinimumLength =3, ErrorMessage ="Full Name must be between 3 and 50 characters")]
        [Required(ErrorMessage = "Full Name is Required")]

        public string FullName { get; set; }
        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Biography is Required")]

        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
