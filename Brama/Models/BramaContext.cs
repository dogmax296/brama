using Microsoft.EntityFrameworkCore;

namespace Brama.Models;

public class BramaContext : DbContext
{
    public BramaContext(DbContextOptions<BramaContext> options)
        : base(options)
    {
    }
}