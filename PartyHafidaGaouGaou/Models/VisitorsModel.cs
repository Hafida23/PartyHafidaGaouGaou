using System.ComponentModel.DataAnnotations;

namespace PartyHafidaGaouGaou.Models
{
    public class VisitorsModel

    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Your First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3)]
        [Display(Name = "Your Last Name")]
        public string SecondName { get; set; }

        [EmailAddress]
        [Display(Name = "Your E-mail Address")]
        public string EmailAdress { get; set; }

        [Required]
        [Display(Name = "Your Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(18, 60, ErrorMessage = "Age must be between 18 - 60")]
        [Display(Name = "Your Age")]
        public int Age { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Your Home Address")]
        public string Adress { get; set; }

        [Required]
        [Range(1000, 9992, ErrorMessage = "Postal Code must be between 1000 - 9992")]
        [Display(Name = "Your Postal Code")]
        public int PostalCode { get; set; }

        [Required]
        [Display(Name = "The City You Live")]
        public string City { get; set; }

        [Display(Name = "Are You a Family Member?")]
        public bool IsFamily { get; set; }

    }
}
