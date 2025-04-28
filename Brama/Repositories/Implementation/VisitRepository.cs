using Brama.Models;
using Brama.Models.Entities;
using Brama.Repositories.Interfaces;

namespace Brama.Repositories.Implementation;

public class VisitRepository : GenericRepository<Visit>, IVisitRepository
{
    public VisitRepository(AppDBContext dbContext) : base(dbContext)
    {
    }
}