namespace ReedExTest
{
    public static class Extensions
    {
        /// <summary>
        /// Returns Address DB Model
        /// </summary>
        /// <param name="input">Instance of Address to be cloned</param>
        /// <returns>Model.Address</returns>
        public static Model.Address ToDataObject(this DTO.Address input)
        {
            if (input == null)
                return null;

            return new Model.Address()
            {
                Id = input.Id,
                Locale = input.Locale,
                AddressLine1 = input.AddressLine1,
                AddressLine2 = input.AddressLine2,
                AddressLine3 = input.AddressLine3,
                City = input.City,
                State = input.State,
                Postcode = input.Postcode,
                CountryIsoCode = input.CountryIsoCode
            };
        }

        /// <summary>
        /// Returns Person DB Model
        /// </summary>
        /// <param name="input">Instance of Person to be cloned</param>
        /// <returns>Model.Person</returns>
        public static Model.Person ToDataObject(this DTO.Person input)
        {
            if (input == null)
                return null;

            var address = input.Address.ToDataObject();

            return new Model.Person()
            {
                Id = input.Id ?? Guid.Empty,
                Email = input.Email,
                FirstName = input.FirstName,
                LastName = input.LastName,
                Address = address,
                AddressId = address.Id,
            };
        }

        /// <summary>
        /// Returns Organisation DB Model
        /// </summary>
        /// <param name="input">Instance of Organisation to be cloned</param>
        /// <returns>Model.Organisation</returns>
        public static Model.Organisation ToDataObject(this DTO.Organisation input)
        {
            if (input == null)
                return null;

            return new Model.Organisation()
            {
                Id = input.Id,
                Name = input.Name,
                Address = input.Address.ToDataObject()
            };
        }

        /// <summary>
        /// Returns Registration DB Model
        /// </summary>
        /// <param name="input">Instance of Registration to be cloned</param>
        /// <returns>Model.Registration</returns>
        public static Model.Registration ToDataObject(this DTO.Registration input)
        {
            if (input == null)
                return null;

            var registration = new Model.Registration()
            {
                Id = input.RegistrationId ?? Guid.Empty,
                RegistrationDate = input.RegistrationDate,
                Locale = input.Locale             
            };

            if (input.Person != null) 
            {
                var person = input.Person.ToDataObject();
                registration.Person = person;
                registration.PersonId = person.Id;
            }

            if (input.Organisation != null)
            {
                var organisation = input.Organisation.ToDataObject();
                registration.Organisation = organisation;
                registration.OrganisationId = organisation.Id;
            }

            return registration;
        }

        /// <summary>
        /// Returns Address OpenApi Model
        /// </summary>
        /// <param name="input">Instance of Address to be cloned</param>
        /// <returns>DTO.Address</returns>
        public static DTO.Address ToApiModel(this Model.Address input)
        {
            if (input == null)
                return null;

            return new DTO.Address()
            {
                Id = input.Id,
                Locale = input.Locale,
                AddressLine1 = input.AddressLine1,
                AddressLine2 = input.AddressLine2,
                AddressLine3 = input.AddressLine3,
                City = input.City,
                State = input.State,
                Postcode = input.Postcode,
                CountryIsoCode = input.CountryIsoCode
            };
        }

        /// <summary>
        /// Returns Person OpenApi Model
        /// </summary>
        /// <param name="input">Instance of Person to be cloned</param>
        /// <returns>DTO.Person</returns>
        public static DTO.Person ToApiModel(this Model.Person input)
        {
            if (input == null)
                return null;

            var address = input.Address.ToApiModel();

            return new DTO.Person()
            {
                Id = input.Id,
                Email = input.Email,   
                FirstName = input.FirstName,
                LastName = input.LastName,
                Address = address               
            };
        }

        /// <summary>
        /// Returns Organisation OpenApi Model
        /// </summary>
        /// <param name="input">Instance of Organisation to be cloned</param>
        /// <returns>DTO.Organisation</returns>
        public static DTO.Organisation ToApiModel(this Model.Organisation input)
        {
            if (input == null)
                return null;

            return new DTO.Organisation()
            {
                Id = input.Id,
                Name = input.Name,
                Address = input.Address.ToApiModel()
            };
        }

        /// <summary>
        /// Returns Registration OpenApi Model
        /// </summary>
        /// <param name="input">Instance of Registration to be cloned</param>
        /// <returns>DTO.Registration</returns>
        public static DTO.Registration ToApiModel(this Model.Registration input)
        {
            if (input == null)
                return null;

            var registration = new DTO.Registration()
            {
                RegistrationId = input.Id,
                RegistrationDate = input.RegistrationDate,
                Locale = input.Locale
            };

            if (input.Person != null)
            {
                registration.Person = input.Person.ToApiModel();
            }

            if (input.Organisation != null)
            {
                var organisation = input.Organisation.ToApiModel();
                registration.Organisation = organisation;
            }

            return registration;
        }
    }
}
