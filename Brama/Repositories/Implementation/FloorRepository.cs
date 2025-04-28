using Brama.Models;
using Brama.Models.Entities;
using Brama.Repositories.Interfaces;

namespace Brama.Repositories.Implementation;

public class FloorRepository : GenericRepository<Floor>, IFloorRepository
{
    public FloorRepository(AppDBContext dbContext) : base(dbContext)
    {
    }
}