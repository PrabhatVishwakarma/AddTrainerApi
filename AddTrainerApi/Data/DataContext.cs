using Microsoft.EntityFrameworkCore;

namespace AddTrainerApi.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option) { }

        public DbSet<Trainer> trainers { get; set; }
    }
}
