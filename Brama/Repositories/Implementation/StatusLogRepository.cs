using Brama.Models;
using Brama.Models.Entities;
using Brama.Repositories.Interfaces;

namespace Brama.Repositories.Implementation;

public class StatusLogRepository : GenericRepository<StatusLog>, IStatusLogRepository
{
    public StatusLogRepository(AppDBContext dbContext) : base(dbContext)
    {
    }
}