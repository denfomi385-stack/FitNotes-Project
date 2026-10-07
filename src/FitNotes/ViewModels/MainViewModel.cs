using System.Collections.ObjectModel;
using FitNotes.Models;

namespace FitNotes.ViewModels;

public class MainViewModel
{
    public ObservableCollection<WorkoutItem> Workouts { get; set; } = new();
}
