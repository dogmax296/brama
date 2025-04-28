using Brama.Models;
using Brama.Models.Entities;
using Brama.Repositories.Interfaces;

namespace Brama.Repositories.Implementation;

public class RoleRepository : GenericRepository<Role>, IRoleRepository
{
    public RoleRepository(AppDBContext dbContext) : base(dbContext)
    {
    }
}