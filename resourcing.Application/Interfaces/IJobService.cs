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
        Job CreateJob(string name, string description);

        // TODO: Add GetAllJobs method
        IEnumerable<Job> GetAllJobs();

        // TODO: Add GetJobById method

        // TODO: Add UpdateExistingJob method

        // TODO: Add DeleteExistingJob method
    }
}
