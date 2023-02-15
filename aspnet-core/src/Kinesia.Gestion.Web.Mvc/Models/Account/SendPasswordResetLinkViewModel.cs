using System.ComponentModel.DataAnnotations;

namespace Kinesia.Gestion.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}