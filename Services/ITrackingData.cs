using System.Threading.Tasks;

namespace ExerciseTracker.Services
{
    public interface ITrackingData
    {
        Task<Exercise> AddAsync(Exercise exercise) {
            throw new NotImplementedException();
        }
        Task<Exercise> GetByIdAsync(int id) {
            throw new NotImplementedException();
        }

        Task<List<Exercise>> GetAllAsync() {
            throw new NotImplementedException();
        }
    }
}