using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using ReedExTest.Controllers;
using Microsoft.EntityFrameworkCore;
using ReedExTest.Model;
using Xunit;

namespace RazorPagesProject.Tests.IntegrationTests
{
    #region snippet1
    public class BasicTests: IClassFixture<WebApplicationFactory<Program>>
    {
        const string jsonSchema = @"
            {
              ""registrationId"": ""3fa85f64-5717-4562-b3fc-2c963f66afa6"",
              ""registrationDate"": ""2022-05-11T12:02:56.609Z"",
              ""locale"": ""EN-US"",
              ""person"": {
                ""id"": ""3fa85f64-5717-4562-b3fc-2c963f66afa7"",
                ""firstName"": ""string"",
                ""lastName"": ""string"",
                ""email"": ""string"",
                ""address"": {
                  ""id"": ""3fa85f64-5717-4562-b3fc-2c963f66afa8"",
                  ""locale"": ""string"",
                  ""addressLine1"": ""string"",
                  ""addressLine2"": ""string"",
                  ""addressLine3"": ""string"",
                  ""city"": ""string"",
                  ""state"": ""string"",
                  ""postcode"": ""string"",
                  ""countryIsoCode"": ""string""
                }
              },
              ""organisationId"": ""3fa85f64-5717-4562-b3fc-2c963f66afa9"",
              ""organisation"": {
                ""id"": ""3fa85f64-5717-4562-b3fc-2c963f66afa9"",
                ""name"": ""string"",
                ""address"": {
                  ""id"": ""3fa85f64-5717-4562-b3fc-2c963f66afa0"",
                  ""locale"": ""string"",
                  ""addressLine1"": ""string"",
                  ""addressLine2"": ""string"",
                  ""addressLine3"": ""string"",
                  ""city"": ""string"",
                  ""state"": ""string"",
                  ""postcode"": ""string"",
                  ""countryIsoCode"": ""string""
                }
              }
            }
        ";

        private readonly WebApplicationFactory<Program> _factory;

        public BasicTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        private Guid regId = Guid.NewGuid();

        private ReedExTest.DTO.Registration GetSampleRegistration() {
            var registration = new ReedExTest.DTO.Registration();

            registration.RegistrationId = regId;
            registration.Locale = "en-US";
            registration.RegistrationDate = DateTime.Now;

            registration.Person = new ReedExTest.DTO.Person()
            {
                Id = Guid.NewGuid(),
                Email = "vcarpov@yahoo.com",
                FirstName = "Vadim",
                LastName = "Carpov",
                Address = new ReedExTest.DTO.Address()
                {
                    Id = Guid.NewGuid(),
                    AddressLine1 = "Allied Testing LLC",
                    AddressLine2 = "Chisinau, Moldova,",
                    AddressLine3 = " Izmail str., ap. 56",
                    City = "Chisinau",
                    State = "Moldova",
                    CountryIsoCode = "MDA",
                    Locale = "md-MD",
                    Postcode = "2044"
                }
            };

            registration.Organisation = new ReedExTest.DTO.Organisation()
            {
                Id = Guid.NewGuid(),
                Name = "Allied Testing",
                Address = new ReedExTest.DTO.Address()
                {
                    Id = Guid.NewGuid(),
                    AddressLine1 = "Allied Testing LLC",
                    AddressLine2 = "Chisinau, Moldova,",
                    AddressLine3 = "Stefan Cel Mare str., ap. 56",
                    City = "Chisinau",
                    State = "Moldova",
                    CountryIsoCode = "MDA",
                    Locale = "md-MD",
                    Postcode = "2044"
                }
            };

            return registration;
        }

        [Fact]
        public async Task RegistrationApiTest()
        {
            // Arrange
            var registration = GetSampleRegistration();

            var dbOptionsBuilder = new DbContextOptionsBuilder<RegistrationContext>();
            RegistrationContext dbContext = new RegistrationContext(dbOptionsBuilder.UseInMemoryDatabase("Tests").Options);
            RegistrationsApi api = new RegistrationsApi(dbContext);

            // Act
            var res = await api.Create(registration);

            var reg = await api.Get(registration.RegistrationId.Value);

            // Assert
            Assert.NotNull(res);
            Assert.NotNull(reg);
            Assert.True(registration.Equals(reg.Value));
        }
    }
    #endregion
}