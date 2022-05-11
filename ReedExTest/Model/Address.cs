using System.ComponentModel.DataAnnotations;

namespace ReedExTest.Model
{
    public class Address
    {
        [Required]
        public Guid Id { get; set; }

        public string Locale { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Postcode { get; set; }

        public string CountryIsoCode { get; set; }        
    }
}
