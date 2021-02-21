using MechanicHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicHelper.Repos
{
    public interface IRepairServiceRepository
    {
        RepairService GetRepairService(Guid id);

        IEnumerable<RepairService> GetAllServices();

        RepairService Add(RepairService service);

        RepairService Update(RepairService repairServiceChanges);

        RepairService Delete(Guid id);
    }
}