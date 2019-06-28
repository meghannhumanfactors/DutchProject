using System.ComponentModel.DataAnnotations;

namespace DutchTreat.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter a name.")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Pleae add a valid email address.")]
        public string UserEmail { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Please add a subject to your message.")]
        public string Subject { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "Your message is to long please reduce it.")]
        public string UserMessage { get; set; }

    }
}
