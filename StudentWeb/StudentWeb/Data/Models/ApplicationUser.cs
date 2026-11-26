namespace StudentWeb.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class ApplicationUser:IdentityUser<Guid>
    {
        [PersonalData]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        public string ? FirstName { get; set; }
        [PersonalData]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        public string ? LastName { get; set; }
        [PersonalData]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }  

    }
}
