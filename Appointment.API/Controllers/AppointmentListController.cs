using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Appointment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentListController : ControllerBase
    {
        // GET api/AppointmentList
        [HttpGet]
        [Authorize(AuthenticationSchemes = "AuthSchemeKey")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Appointment1", "Appointment2", "Appointment3", "Appointment4", "Appointment5" };
        }
    }
}
