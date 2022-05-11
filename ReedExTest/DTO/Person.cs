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
using System.ComponentModel.DataAnnotations;

namespace ReedExTest.DTO
{
    /// <summary>
    /// The details of a person
    /// </summary>
    [DataContract]
    public partial class Person : IEquatable<Person>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The first name of the person.
        /// </summary>
        /// <value>The first name of the person.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person.
        /// </summary>
        /// <value>The last name of the person.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The email of the person.
        /// </summary>
        /// <value>The email of the person.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Person {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as Person);
        }

        /// <summary>
        /// Returns true if Person instances are equal
        /// </summary>
        /// <param name="input">Instance of Person to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Person input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) &&
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) &&
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) &&
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                return hashCode;
            }
        }
    }
}
