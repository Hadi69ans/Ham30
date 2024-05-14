using System.ComponentModel.DataAnnotations;

namespace Ham30.Server.Services.Identity.Requests
{
    public class TokenRequest
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}