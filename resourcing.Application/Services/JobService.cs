using AutoMapper;
using Resourcing.Application.Interfaces;
using Resourcing.Application.Models;
using Resourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Resourcing.Application.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public JobService(IJobRepository jobRepository, IMapper mapper) 
        { 
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public JobDto GetJobById(Guid jobId)
        {
            var job = _jobRepository.GetJobById(jobId);
            if (job == null) 
            {
                // exception
                return null;
            }

            var mappedJob = _mapper.Map<JobDto>(job);
            return mappedJob;
        }

        public Job CreateJob(string name, string description, DateTime startDate, DateTime endDate)
        {
            var newJob = new Job 
            { 
                Name = name, 
                Description = description, 
                StartDate = startDate, 
                EndDate = endDate 
            };
            return _jobRepository.CreateJob(newJob);
        }

        public IEnumerable<Job> GetAllJobs()
        {
            return _jobRepository.GetAllJobs();
        }

        public JobDto UpdateExistingJob(JobDto changeJob, Guid id)
        {
            // i need to get the id if it exists
            var existingJob = GetJobById(id);

            if (existingJob == null)
            {
                // exception ( job does not exist )
                return null;
            }
            // update that item with new details in job

            var updatedJob = _mapper.Map<Job>(changeJob);
            _jobRepository.UpdateJob(updatedJob);
            return changeJob;
        }

        public JobDto DeleteJob(Guid jobId)
        {
            // check if job exists then get properties

            var existingJob = GetJobById(jobId);

            if (existingJob == null)
            {
                // exception ( job does not exist )
                return null;
            }
            // if not null call repository

            var mappedJob = _mapper.Map<Job>(existingJob);
            _jobRepository.DeleteJob(mappedJob);
            return existingJob;

        }
    }
}
