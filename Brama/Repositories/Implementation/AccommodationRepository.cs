using Brama.Models;
using Brama.Models.Entities;
using Brama.Repositories.Interfaces;

namespace Brama.Repositories.Implementation;

public class AccommodationRepository : GenericRepository<Accommodation>, IAccommodationRepository
{
    public AccommodationRepository(AppDBContext dbContext) : base(dbContext)
    {
    }
}