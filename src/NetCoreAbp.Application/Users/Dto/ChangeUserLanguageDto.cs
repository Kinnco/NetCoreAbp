using System.ComponentModel.DataAnnotations;

namespace NetCoreAbp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}