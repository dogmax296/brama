using Brama.Models;
using Brama.Repositories.Implementation;
using Brama.Repositories.Interfaces;
using Brama.Services.Configuration;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseLazyLoadingProxies()
        .UseNpgsql(builder.Configuration.GetConnectionString("mainDB"))
);
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<IAccommodationRepository,AccommodationRepository>();
builder.Services.AddScoped<IBuildingRepository,BuildingRepository>();
builder.Services.AddScoped<IBuildingUnitRepository,BuildingUnitRepository>();
builder.Services.AddScoped<IEntranceRepository,EntranceRepository>();
builder.Services.AddScoped<IFloorRepository,FloorRepository>();
builder.Services.AddScoped<IPersonRepository,PersonRepository>();
builder.Services.AddScoped<IRoleRepository,RoleRepository>();
builder.Services.AddScoped<IStatusRepository,StatusRepository>();
builder.Services.AddScoped<IStatusLogRepository,StatusLogRepository>();
builder.Services.AddScoped<IVisitRepository,VisitRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();