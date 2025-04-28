using Brama.Models;
using Brama.Models.Entities;
using Brama.Repositories.Interfaces;

namespace Brama.Repositories.Implementation;

public class EntranceRequestRepository : GenericRepository<EntranceRequest>, IEntranceRequestRepository
{
    public EntranceRequestRepository(AppDBContext dbContext) : base(dbContext)
    {
    }
}