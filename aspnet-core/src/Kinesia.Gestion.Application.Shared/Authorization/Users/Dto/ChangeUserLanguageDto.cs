using System.ComponentModel.DataAnnotations;

namespace Kinesia.Gestion.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
