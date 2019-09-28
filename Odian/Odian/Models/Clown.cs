
namespace Odian.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Clown
    {
        public enum TypeTricks {
            Nuria,
            Niño,
            Niña
        }

        [Key]
        public int ClownID { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 2)]
        public string NickName { get; set; }

        [Required]
        public TypeTricks Tricks { get; set; }

        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter correct email address")]
        public string Email { get; set; }

        [Display(Description = "Cumpleaños")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaDeNacimiento { get; set; }
        public int Birthday { get; set; }

    }
}