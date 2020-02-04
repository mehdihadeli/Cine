using System.Collections.Generic;
using System.Threading.Tasks;
using Cine.Modules.Schedules.Core.Entities;
using Cine.Shared.BuildingBlocks;

namespace Cine.Modules.Schedules.Core.Repositories
{
    public interface IHallsRepository
    {
        Task<IEnumerable<Hall>> GetAsync();
        Task AddAsync(Hall hall);
        Task DeleteAsync(EntityId hall);
    }
}
