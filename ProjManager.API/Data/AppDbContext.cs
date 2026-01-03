using Microsoft.EntityFrameworkCore;

namespace ProjManager.API.Data;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}