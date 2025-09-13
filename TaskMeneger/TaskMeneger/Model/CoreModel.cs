using CommunityToolkit.Mvvm.ComponentModel;

namespace TaskMeneger.Model;

public class CoreModel : ObservableObject
{
    private bool _isChecked;

    public int Id { get; }
    public string Name => $"Ядро {Id}";

    public bool IsChecked
    {
        get => _isChecked;
        set => SetProperty(ref _isChecked, value);
    }

    public CoreModel(int id)
    {
        Id = id;
        IsChecked = true; 
    }
}