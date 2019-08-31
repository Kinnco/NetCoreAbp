using System.ComponentModel.DataAnnotations;

namespace NetCore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}