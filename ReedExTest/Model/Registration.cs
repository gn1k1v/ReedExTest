using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ReedExTest.Model
{
    public class Registration
    {
        [Required]
        public Guid Id { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public string Locale { get; set; }

        public Guid PersonId { get; set; }

        public Person Person { get; set; }

        public Guid OrganisationId { get; set; }

        public Organisation Organisation { get; set; }                
    }
}
