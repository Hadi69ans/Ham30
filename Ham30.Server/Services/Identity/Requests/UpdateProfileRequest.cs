using System.ComponentModel.DataAnnotations;

namespace Ham30.Server.Services.Identity.Requests
{
    public class UpdateProfileRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}