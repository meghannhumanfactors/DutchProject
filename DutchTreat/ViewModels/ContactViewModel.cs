using System.ComponentModel.DataAnnotations;

namespace DutchTreat.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter a name.")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string UserEmail { get; set; }


        [MaxLength(75, ErrorMessage = "Your subject is to long please reduce it.")]
        public string Subject { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "Your message is to long please reduce it.")]
        public string UserMessage { get; set; }

    }
}
