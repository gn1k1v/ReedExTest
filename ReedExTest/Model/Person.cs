using System.ComponentModel.DataAnnotations;

namespace ReedExTest.Model
{
    public partial class Person
    {
        [Required]
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Guid AddressId { get; set; }

        public Address Address { get; set; }        
    }
}
