using Resourcing.Application.Models;
using Resourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resourcing.Application.Interfaces
{
    public interface IJobService
    {
        // TODO: Add CreateJob method
        Job CreateJob(string name, string description, DateTime startDate, DateTime endDate);

        // TODO: Add GetAllJobs method
        IEnumerable<Job> GetAllJobs();

        // TODO: Add GetJobById method
        JobDto GetJobById(Guid jobId);

        // TODO: Add UpdateExistingJob method

        JobDto UpdateExistingJob(JobDto job, Guid id);

        // TODO: Add DeleteExistingJob method

        JobDto DeleteJob(Guid jobId);
    }
}
