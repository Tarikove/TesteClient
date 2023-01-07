using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TesteClient.Models
{
    public class ApplicationUser:IdentityUser    
    {
        public enum eCivility
        {
            Madame,
            Monsieur,
            Autre
        }

        [Display(Name = "Civilité")]
        public eCivility Civility { get; set; }

        [Display(Name = "Nom")]
        [MaxLength(30)]
        public string LastName { get; set; }


        [Display(Name = "Prénom")]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Display(Name = "Date de naissance")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", NullDisplayText = "Inconnue")]
        public DateTime? BirthDate { get; set; }
    }
}
