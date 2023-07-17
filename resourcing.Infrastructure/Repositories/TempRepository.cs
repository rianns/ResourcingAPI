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
    public class TempRepository : ITempRepository
    {
        private readonly ResourcingDbContext _dbContext;

        public TempRepository(ResourcingDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public Temp CreateTemp(Temp temp)
        {
            _dbContext.Temps.Add(temp);
            _dbContext.SaveChanges();
            return temp;
        }

        public Temp DeleteTemp(Temp temp)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Temp> GetAllTemps()
        {
            throw new NotImplementedException();
        }

        public Temp GetTempById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Temp UpdateTemp(Temp temp)
        {
            throw new NotImplementedException();
        }

        Temp ITempRepository.CreateTemp(Temp temp)
        {
            throw new NotImplementedException();
        }
    }
}
