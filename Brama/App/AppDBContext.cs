using Brama.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Brama.Models;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }
    
    public DbSet<Accommodation> Accommodations { get; set; }
    public DbSet<Building> Buildings { get; set; }
    public DbSet<BuildingUnit> BuildingUnits { get; set; }
    public DbSet<Entrance> Entrances { get; set; }
    public DbSet<EntranceRequest> EntranceRequests { get; set; }
    public DbSet<Floor> Floors { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<StatusLog> StatusLogs { get; set; }
    public DbSet<Visit> Visits { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.Entity<Building>()
                .HasMany(e => e.BuildingUnits)
                .WithOne(e => e.Building)
                .HasForeignKey(e => e.BuildingId)
                .HasPrincipalKey(e => e.Id);

            modelBuilder.Entity<BuildingUnit>()
                .HasMany(e => e.Floors)
                .WithOne(e => e.BuildingUnit)
                .HasForeignKey(e => e.BuildingUnitId)
                .HasPrincipalKey(e => e.Id);

            modelBuilder.Entity<BuildingUnit>()
                .HasMany(e => e.Entrances)
                .WithOne(e => e.BuildingUnit)
                .HasForeignKey(e => e.BuildingUnitId)
                .HasPrincipalKey(e => e.Id);

            modelBuilder.Entity<Floor>()
                .HasMany(e => e.Accommodations)
                .WithOne(e => e.Floor)
                .HasForeignKey(e => e.FloorId)
                .HasPrincipalKey(e => e.Id);

            modelBuilder.Entity<Accommodation>()
                .HasMany(e => e.Statuses)
               .WithOne(e => e.Accommodation)
               .HasForeignKey(e => e.AccommodationId)
               .HasPrincipalKey(e => e.Id);
            
            modelBuilder.Entity<Status>()
                .HasMany(e => e.Visits)
                .WithOne(e => e.Status)
                .HasForeignKey(e => e.StatusId)
                .HasPrincipalKey(e => e.Id);
            
            modelBuilder.Entity<Status>()
                .HasMany(e => e.GivenStatusLogs)
                .WithOne(e => e.StatusFrom)
                .HasForeignKey(e => e.StatusIdFrom)
                .HasPrincipalKey(e => e.Id);
            
            modelBuilder.Entity<Role>()
                .HasMany(e => e.Statuses)
                .WithOne(e => e.Role)
                .HasForeignKey(e=> e.RoleId)
                .HasPrincipalKey(e => e.Id);
            
            modelBuilder.Entity<Person>()
                .HasMany(e => e.Statuses)
                .WithOne(e => e.Person)
                .HasForeignKey(e => e.PersonId)
                .HasPrincipalKey(e => e.Id);
            
            modelBuilder.Entity<Person>()
                .HasMany(e => e.RecievedStatusLogs)
                .WithOne(e => e.PersonTo)
                .HasForeignKey(e => e.PersonIdTo)
                .HasPrincipalKey(e => e.Id);

            modelBuilder.Entity<StatusLog>()
                .HasOne(e => e.EntranceRequest)
                .WithOne(e => e.StatusLog)
                .HasForeignKey<StatusLog>(e => e.EntranceRequestId);
            
            modelBuilder.Entity<Entrance>()
                .HasMany(e => e.EntranceRequests)
                .WithOne(e => e.Entrance)
                .HasForeignKey(e => e.EntranceId)
                .HasPrincipalKey(e => e.Id);
            
            modelBuilder.Entity<Entrance>()
                .HasMany(e => e.Visits)
                .WithOne(e => e.Entrance)
                .HasForeignKey(e => e.EntranceId)
                .HasPrincipalKey(e => e.Id);
            
    }
}