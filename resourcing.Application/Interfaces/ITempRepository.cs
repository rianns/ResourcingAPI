using Resourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resourcing.Application.Interfaces
{
    public interface ITempRepository
    {
        // Get Temp by ID

        Temp GetTempById(Guid id);

        // Get all Temps

        IEnumerable<Temp> GetAllTemps();

        // Create new Temp
        Temp CreateTemp(Temp temp);

        // Update existing Temp
        Temp UpdateTemp(Temp temp);

        // Delete existing Temp
        Temp DeleteTemp(Temp temp);

    }
}
