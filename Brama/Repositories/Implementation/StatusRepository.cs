using Brama.Models;
using Brama.Models.Entities;
using Brama.Repositories.Interfaces;

namespace Brama.Repositories.Implementation;

public class StatusRepository : GenericRepository<Status>, IStatusRepository
{
    public StatusRepository(AppDBContext dbContext) : base(dbContext)
    {
    }
}