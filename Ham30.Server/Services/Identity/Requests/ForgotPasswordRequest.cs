using System.ComponentModel.DataAnnotations;

namespace Ham30.Server.Services.Identity.Requests
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}