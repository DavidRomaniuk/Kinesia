using System.ComponentModel.DataAnnotations;

namespace Kinesia.Gestion.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}