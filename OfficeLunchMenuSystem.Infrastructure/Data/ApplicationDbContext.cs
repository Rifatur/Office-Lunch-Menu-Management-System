using Microsoft.EntityFrameworkCore;
using OfficeLunchMenuSystem.Domain.Entities;

namespace OfficeLunchMenuSystem.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<LunchMenu> lunchMenus { get; set; }
    }
}
