using Microsoft.AspNetCore.Mvc;
using Resourcing.Application.Interfaces;
using Resourcing.Application.Models;
using Resourcing.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resourcing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService) 
        {
            _jobService = jobService;
        }

        // GET: api/<JobController>
        [HttpGet]
        public ActionResult<IEnumerable<JobDto>> Get()
        {
            var allJobs = _jobService.GetAllJobs();
            return Ok(allJobs);
        }

        // GET api/<JobController>/5
        [HttpGet("{id}")]
        public ActionResult<JobDto> Get(Guid id)
        {
            return _jobService.GetJobById(id);
        }

        // POST api/<JobController>
        [HttpPost]
        public ActionResult<JobDto> Post([FromBody] JobDto request)
        {
            try
            {
                var postJob = _jobService.CreateJob(request.Name, request.Description, request.StartDate, request.EndDate);

                return Ok(postJob);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException)
                {
                    return BadRequest(ex);
                }
                throw;
            }
        }

        // Put api/<JobController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] JobDto request, Guid id)
        {

            var updateJob = _jobService.UpdateExistingJob(request, id);

            return Ok(updateJob);
        }

        // DELETE api/<JobController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _jobService.DeleteJob(id);
        }
    }
}
