/* 
 * Reed Exhibitions Mercury Technical Test
 *
 * Rest API specification for Technical Test
 *
 * OpenAPI spec version: v1
 * 
 */
using ReedExTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ReedExTest.Controllers
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    [ApiController]
    [Route("/api/v1/registrations")]
    public class RegistrationsApi : ControllerBase
    {
        // </snippet_ClassDeclaration>
        private readonly RegistrationContext _context;

        public RegistrationsApi(RegistrationContext context) =>
            _context = context;

        [HttpGet("{registrationId}")]
        public async Task<ActionResult<DTO.Registration>> Get(Guid registrationId)
        {
            var item = await _context.Registrations.SingleAsync(r => r.Id == registrationId);

            _context.Entry(item).Reference(r => r.Organisation).Load();

            _context.Entry(item).Reference(r => r.Person).Load();

            if (item.Organisation != null && item.Organisation.AddressId != Guid.Empty)
            {
                _context.Entry(item.Organisation).Reference(o => o.Address).Load();
            }

            if (item.Person != null && item.Person.AddressId != Guid.Empty) {
                _context.Entry(item.Person).Reference(p => p.Address).Load();
            }

            if (item is null)
            {
                return NotFound();
            }

            return item.ToApiModel();
        }

        // <snippet_Create>
        /// <summary>
        /// Creates a Registration.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>A newly created Registration</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(DTO.Registration item)
        {
            _context.Registrations.Add(item.ToDataObject());
            await _context.SaveChangesAsync();

            return new CreatedResult("/api/v1/registrations/" + item.RegistrationId, item);
        }
    }
}
