using MechanicHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicHelper.Repos
{
    public class SQLRepairServiceRepository : IRepairServiceRepository
    {
        private readonly MechanicDbContext context;

        public SQLRepairServiceRepository(MechanicDbContext context)
        {
            this.context = context;
        }

        public RepairService Add(RepairService service)
        {
            context.RepairServices.Add(service);
            context.SaveChanges();
            return service;
        }

        public RepairService Delete(Guid id)
        {
            RepairService repairService = context.RepairServices.Find(id);

            if (repairService != null)
            {
                context.RepairServices.Remove(repairService);
                context.SaveChanges();
            }

            return repairService;
        }

        public IEnumerable<RepairService> GetAllServices()
        {
            return context.RepairServices;
        }

        public RepairService GetRepairService(Guid id)
        {
            return context.RepairServices.Find(id);
        }

        public RepairService Update(RepairService repairServiceChanges)
        {
            var repairService = context.RepairServices.Attach(repairServiceChanges);
            repairService.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return repairServiceChanges;
        }
    }
}