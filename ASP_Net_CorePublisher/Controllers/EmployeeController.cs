using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASP_Net_CorePublisher.Models;
namespace ASP_Net_CorePublisher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private QueuePublisher queuePublisher;
        public EmployeeController(QueuePublisher queuePublisher)
        {
            this.queuePublisher = queuePublisher;
        }
        [HttpPost]
        public IActionResult Post(Employee emp)
        {
            queuePublisher.Publish(emp);
            return Ok("Message is added in Queue");
        }

    }
}