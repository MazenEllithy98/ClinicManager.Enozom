using ClinicManager.Enozom.Core.Entities;
using ClinicManager.Enozom.Core.Repositories.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ClinicManager.Enozom.APIs.Controllers
{
    public class DoctorsController : BaseApiController
    {
        private readonly IGenericRepository<Doctor> _doctorsRepo;

        public DoctorsController(IGenericRepository<Doctor> doctorsRepo)
        {
            _doctorsRepo = doctorsRepo;
        }
        // /api/doctors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctors()
        {
            var doctors = await _doctorsRepo.GetAllAsync();
            return Ok(doctors);
        }
        // /api/doctors/2
        [HttpGet("{id}")]
        public async Task<ActionResult<Doctor>> GetDoctorById(int id)
        {

            var doctorById = await _doctorsRepo.GetAsync(id);
            if (doctorById == null)
            {
                return NotFound(new { Message = "Not Found", StatusCode = 404 });
            }
            return Ok(doctorById);
        }

        // POST /api/doctors
        [HttpPost]
        public async Task<ActionResult<Doctor>> AddDoctor(Doctor doctor)
        {
            await _doctorsRepo.AddAsync(doctor);

            return CreatedAtAction(nameof(GetDoctorById), new { id = doctor.Id }, doctor);
        }

        // PUT /api/doctors/{doctorId}/availability
        [HttpPut("{doctorId}/availability")]
        public async Task<IActionResult> UpdateDoctorAvailability(int doctorId, [FromBody] Availability availability)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var doctor = await _doctorsRepo.GetAsync(doctorId);
            if (doctor == null)
            {
                return NotFound(new { Message = "Not Found", StatusCode = 404 });
            }

            // Update the doctor's availability
            doctor.Availabilities = doctor.Availabilities ?? new List<Availability>();
            var existingAvailability = doctor.Availabilities.FirstOrDefault(a => a.DayOfWeek == availability.DayOfWeek);
            if (existingAvailability != null)
            {
                // If the availability already exists, update it
                existingAvailability.StartTime = availability.StartTime;
                existingAvailability.EndTime = availability.EndTime;
            }
            else
            {
                // If the availability doesn't exist, add it
                doctor.Availabilities.Add(availability);
            }

            await _doctorsRepo.UpdateAsync(doctor);

            return NoContent();
        }

    }
}
