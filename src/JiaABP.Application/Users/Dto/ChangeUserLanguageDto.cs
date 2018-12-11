using System.ComponentModel.DataAnnotations;

namespace JiaABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}