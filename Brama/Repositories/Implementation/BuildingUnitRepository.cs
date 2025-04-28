using Brama.Models;
using Brama.Models.Entities;
using Brama.Repositories.Interfaces;

namespace Brama.Repositories.Implementation;

public class BuildingUnitRepository : GenericRepository<BuildingUnit>, IBuildingUnitRepository
{
    public BuildingUnitRepository(AppDBContext dbContext) : base(dbContext)
    {
    }
}