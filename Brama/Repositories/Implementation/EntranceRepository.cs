using Brama.Models;
using Brama.Models.Entities;
using Brama.Repositories.Interfaces;

namespace Brama.Repositories.Implementation;

public class EntranceRepository : GenericRepository<Entrance>, IEntranceRepository
{
    public EntranceRepository(AppDBContext dbContext) : base(dbContext)
    {
    }
}