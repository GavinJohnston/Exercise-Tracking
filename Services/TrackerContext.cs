using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.Services
{
    public class TrackerContext : DbContext
    {
        public TrackerContext(DbContextOptions<TrackerContext> options) : base(options) {}
        public DbSet<Exercise> ExerciseTracking {get; set;}
    }
}