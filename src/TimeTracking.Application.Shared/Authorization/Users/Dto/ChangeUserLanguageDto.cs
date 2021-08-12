using System.ComponentModel.DataAnnotations;

namespace TimeTracking.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
