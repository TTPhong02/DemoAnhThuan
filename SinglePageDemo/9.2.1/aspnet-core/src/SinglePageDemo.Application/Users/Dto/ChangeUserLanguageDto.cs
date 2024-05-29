using System.ComponentModel.DataAnnotations;

namespace SinglePageDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}