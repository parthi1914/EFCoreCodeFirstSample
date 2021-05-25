using System.Collections.Generic;
using EFCoreCodeFirstSample.Models;
using EFCoreCodeFirstSample.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreCodeFirstSample.Controllers
{
    [Route("api/kiosk")]
    [ApiController]
    public class KioskController : ControllerBase
    {
        private readonly IDataRepository<Kiosk> _dataRepository;

        public KioskController(IDataRepository<Kiosk> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/kiosk
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Kiosk> kioskList = _dataRepository.GetAll();
            return Ok(kioskList);
        }

        // GET: api/kiosk/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Kiosk kiosk = _dataRepository.Get(id);

            if (kiosk == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            return Ok(kiosk);
        }

        // POST: api/kiosk
        [HttpPost]
        public IActionResult Post([FromBody] Kiosk kiosk)
        {
            if (kiosk == null)
            {
                return BadRequest("Employee is null.");
            }

            _dataRepository.Add(kiosk);
            return CreatedAtRoute(
                  "Get",
                  new { Id = kiosk.KioskId },
                  kiosk);
        }

        // PUT: api/kiosk/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Kiosk kiosk)
        {
            if (kiosk == null)
            {
                return BadRequest("Employee is null.");
            }

            Kiosk kioskToUpdate = _dataRepository.Get(id);
            if (kioskToUpdate == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _dataRepository.Update(kioskToUpdate, kiosk);
            return NoContent();
        }

        // DELETE: api/kiosk/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Kiosk kiosk = _dataRepository.Get(id);
            if (kiosk == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _dataRepository.Delete(kiosk);
            return NoContent();
        }
    }
}