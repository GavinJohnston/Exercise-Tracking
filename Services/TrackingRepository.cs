using Microsoft.EntityFrameworkCore;
using ExerciseTracker.Services;

namespace ExerciseTracker
{
    public class TrackingRepository : ITrackingData
    {

        private readonly TrackerContext db;

        public TrackingRepository(TrackerContext db) {
            this.db = db;
        }

        public async Task<Exercise> AddAsync(Exercise exercise) {
            db.ExerciseTracking.Add(exercise);
            await db.SaveChangesAsync();

            return exercise;
        }
        public async Task<Exercise> GetByIdAsync(int id) {          

            var item  = await db.ExerciseTracking.FirstOrDefaultAsync(book => book.ID == id);

            if (item != null) {
                return item;
            } else {
                throw new NullReferenceException();
            }
        }

        public async Task<List<Exercise>> GetAllAsync() {
            return await db.ExerciseTracking.ToListAsync();
        }
    }
}