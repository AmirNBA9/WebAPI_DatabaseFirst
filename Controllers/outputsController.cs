using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DB_First_API.Models.DB;

namespace DB_First_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class outputsController : ControllerBase
    {
        private readonly DB_Demo_APIContext _context;

        public outputsController(DB_Demo_APIContext context)
        {
            _context = context;
        }

        // POST: api/outputs  
        [HttpPost]
        public async Task<ActionResult<IEnumerable<output>>> Getoutput(Input input)
        {
            string StoredProc = "exec CreateAppointment " +
                    "@ClinicID = " + input.ClinicId + "," +
                    "@AppointmentDate = '" + input.AppointmentDate + "'," +
                    "@FirstName= '" + input.FirstName + "'," +
                    "@LastName= '" + input.LastName + "'," +
                    "@PatientID= " + input.PatientId + "," +
                    "@AppointmentStartTime= '" + input.AppointmentStartTime + "'," +
                    "@AppointmentEndTime= '" + input.AppointmentEndTime + "'";

            //return await _context.output.ToListAsync();  
            return await _context.output.FromSqlRaw(StoredProc).ToListAsync();
        }

    }
}