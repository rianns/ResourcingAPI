using Resourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resourcing.Application.Interfaces
{
    public interface IJobRepository
    {
        // Get by Job ID

        // Get all Jobs
        IEnumerable<Job> GetAllJobs();

        // Create new Job
        Job CreateJob(Job job);

        // Update existing Job

        // Delete existing Job
    }
}
