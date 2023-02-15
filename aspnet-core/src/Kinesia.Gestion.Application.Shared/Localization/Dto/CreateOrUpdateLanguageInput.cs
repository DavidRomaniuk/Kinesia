using System.ComponentModel.DataAnnotations;

namespace Kinesia.Gestion.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}