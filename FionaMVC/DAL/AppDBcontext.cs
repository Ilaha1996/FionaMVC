using Microsoft.EntityFrameworkCore;
using FionaMVC.Entities;

namespace FionaMVC.DAL
{

    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<Slide> Slides { get; set; }

    }

}
