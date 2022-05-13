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
using System.ComponentModel.DataAnnotations.Schema;

namespace ReedExTest.DTO
{
    /// <summary>
    /// RegistrationResponse
    /// </summary>
    [DataContract]
    public class Registration : IEquatable<Registration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Registration" /> class.
        /// </summary>
        /// <param name="registrationId">registrationId.</param>
        public Registration(Guid? registrationId = default(Guid?))
        {
            this.RegistrationId = registrationId;
        }


        /// <summary>
        /// Gets or Sets RegistrationId
        /// </summary>
        [DataMember(Name = "registrationId", EmitDefaultValue = false)]
        public Guid? RegistrationId { get; set; }

        /// <summary>
        /// The date when the person registered.
        /// </summary>
        /// <value>The date when the person registered.</value>
        [DataMember(Name = "registrationDate", EmitDefaultValue = false)]
        public DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        public Person Person { get; set; }

        /// <summary>
        /// Gets or Sets Organisation
        /// </summary>
        [DataMember(Name = "organisation", EmitDefaultValue = false)]
        public Organisation Organisation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetRegistrationResponse {\n");
            sb.Append("  Id: ").Append(RegistrationId).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  Organisation: ").Append(Organisation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if GetRegistrationResponse instances are equal
        /// </summary>
        /// <param name="reg">Instance of GetRegistrationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Registration reg)
        {
            if (reg == null)
                return false;

            return
                (
                    this.RegistrationId == reg.RegistrationId ||
                    (this.RegistrationId != null &&
                    this.RegistrationId.Equals(reg.RegistrationId))
                ) &&
                (
                    this.RegistrationDate == reg.RegistrationDate ||
                    (this.RegistrationDate != null &&
                    this.RegistrationDate.Equals(reg.RegistrationDate))
                ) &&
                (
                    this.Locale == reg.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(reg.Locale))
                ) &&
                (
                    this.Person == reg.Person ||
                    (this.Person != null &&
                    this.Person.Equals(reg.Person))
                ) &&
                (
                    this.Organisation == reg.Organisation ||
                    (this.Organisation != null &&
                    this.Organisation.Equals(reg.Organisation))
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
                if (this.RegistrationId != null)
                    hashCode = hashCode * 59 + this.RegistrationId.GetHashCode();
                if (this.RegistrationDate != null)
                    hashCode = hashCode * 59 + this.RegistrationDate.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Person != null)
                    hashCode = hashCode * 59 + this.Person.GetHashCode();
                if (this.Organisation != null)
                    hashCode = hashCode * 59 + this.Organisation.GetHashCode();
                return hashCode;
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Registration);
        }
    }
}
