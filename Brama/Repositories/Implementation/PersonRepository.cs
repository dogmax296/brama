using Brama.Models;
using Brama.Models.Entities;
using Brama.Repositories.Interfaces;

namespace Brama.Repositories.Implementation;

public class PersonRepository : GenericRepository<Person>, IPersonRepository
{
    public PersonRepository(AppDBContext dbContext) : base(dbContext)
    {
    }
}