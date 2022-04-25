using Microsoft.AspNetCore.Mvc;

namespace ExerciseTracker.Controllers
{
    [Route("api/[controller]")]
    public class ExerciseTrackingController : ControllerBase
    {
        private readonly ITrackingData _data;

        public ExerciseTrackingController(ITrackingData data) {
            _data = data;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll() {

            return Ok(await _data.GetAllAsync());
        }

        [HttpGet("{id}")]       
        public async Task<IActionResult> GetById(int id) {  

            return Ok(await _data.GetByIdAsync(id));
        }

        [HttpPost]

        public async Task<IActionResult> AddExercise(Exercise exercise) {
            return Ok(await _data.AddAsync(exercise));
        }

    }
}