/* 
 * Reed Exhibitions Mercury Technical Test
 *
 * Rest API specification for Technical Test
 *
 * OpenAPI spec version: v1
 * 
*/
using System.Text;
using System.Runtime.Serialization;

namespace ReedExTest.DTO
{
    /// <summary>
    /// The address details.
    /// </summary>
    [DataContract]
    public partial class Address : IEquatable<Address>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Address line 1.
        /// </summary>
        /// <value>Address line 1.</value>
        [DataMember(Name = "addressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2.
        /// </summary>
        /// <value>Address line 2.</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Address line 3.
        /// </summary>
        /// <value>Address line 3.</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        /// <value>The city.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The state.
        /// </summary>
        /// <value>The state.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The post code.
        /// </summary>
        /// <value>The post code.</value>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// The ISO3 code of the country.
        /// </summary>
        /// <value>The ISO3 code of the country.</value>
        [DataMember(Name = "countryIsoCode", EmitDefaultValue = false)]
        public string CountryIsoCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  CountryIsoCode: ").Append(CountryIsoCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) &&
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) &&
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) &&
                (
                    this.AddressLine3 == input.AddressLine3 ||
                    (this.AddressLine3 != null &&
                    this.AddressLine3.Equals(input.AddressLine3))
                ) &&
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) &&
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) &&
                (
                    this.CountryIsoCode == input.CountryIsoCode ||
                    (this.CountryIsoCode != null &&
                    this.CountryIsoCode.Equals(input.CountryIsoCode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressLine3 != null)
                    hashCode = hashCode * 59 + this.AddressLine3.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.CountryIsoCode != null)
                    hashCode = hashCode * 59 + this.CountryIsoCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
