using System.ComponentModel.DataAnnotations;

namespace ExerciseTracker
{
    public class Exercise
    {
        [Key]
        public int ID {get; set;}
        public DateTime DateStart {get; set;}
        public DateTime DateEnd {get; set;}
        public TimeSpan Duration {get; set;}
        public string? Comments {get; set;}
    }
}