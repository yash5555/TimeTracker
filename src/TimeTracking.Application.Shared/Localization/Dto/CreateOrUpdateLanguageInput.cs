using System.ComponentModel.DataAnnotations;

namespace TimeTracking.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}