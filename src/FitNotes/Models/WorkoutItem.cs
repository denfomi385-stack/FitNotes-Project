namespace FitNotes.Models;

public class WorkoutItem
{
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string ExerciseName { get; set; } = string.Empty;
    public double Weight { get; set; }
    public int Reps { get; set; }
}
