using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ReedExTest.Model
{
    public class Organisation
    {
        [Required]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid AddressId { get; set; }

        public Address Address { get; set; }
    }
}
