using Microsoft.EntityFrameworkCore;
using ProjManager.API.Entities;
namespace ProjManager.API.Data;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
}