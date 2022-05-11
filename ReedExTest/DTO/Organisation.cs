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
    /// The details of an organisation
    /// </summary>
    [DataContract]
    public class Organisation : IEquatable<Organisation>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the company
        /// </summary>
        /// <value>The name of the company</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

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
            sb.Append("class Organisation {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Organisation);
        }

        /// <summary>
        /// Returns true if Organisation instances are equal
        /// </summary>
        /// <param name="input">Instance of Organisation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Organisation input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                return hashCode;
            }
        }
    }
}
