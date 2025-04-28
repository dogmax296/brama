using Brama.Models;
using Brama.Models.Entities;
using Brama.Repositories.Interfaces;

namespace Brama.Repositories.Implementation;

public class BuildingRepository : GenericRepository<Building>, IBuildingRepository
{
    public BuildingRepository(AppDBContext dbContext) : base(dbContext)
    {
    }
}