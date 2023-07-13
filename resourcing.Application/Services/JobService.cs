using Resourcing.Application.Interfaces;
using Resourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resourcing.Application.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository) 
        { 
            _jobRepository = jobRepository;
        }

        public Job CreateJob(string name, string description)
        {
            var newJob = new Job { Name = name, Description = description };
            return _jobRepository.CreateJob(newJob);
        }

        public IEnumerable<Job> GetAllJobs()
        {
            return _jobRepository.GetAllJobs();
        }
    }
}
