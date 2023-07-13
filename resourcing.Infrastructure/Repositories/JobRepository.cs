using Microsoft.EntityFrameworkCore;
using Resourcing.Application.Interfaces;
using Resourcing.Domain.Entities;
using Resourcing.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resourcing.Infrastructure.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly ResourcingDbContext _dbContext;
        public static IEnumerable<Job>? jobs;

        public JobRepository(ResourcingDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }
        public Job CreateJob(Job job)
        {
            _dbContext.Jobs.Add(job);
            _dbContext.SaveChanges();
            return job;
        }

        public IEnumerable<Job> GetAllJobs()
        {
            return _dbContext.Jobs.ToList();
        }
    }
}
