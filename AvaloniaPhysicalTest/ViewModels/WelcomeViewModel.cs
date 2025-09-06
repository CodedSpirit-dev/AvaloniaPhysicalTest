using ReactiveUI;
using System;
using System.Windows.Input; // Para ICommand

namespace AvaloniaPhysicalTest.ViewModels;

public enum UnitSystem { Metric, Imperial }
public enum Gender { Male, Female }

public class WelcomeViewModel : ReactiveObject
{
    private int _currentStep;
    private UnitSystem _selectedUnitSystem;
    private string _name = string.Empty;
    private string _lastName = string.Empty;
    private double _height;
    private double _width;
    private int _age;
    private Gender _gender;

    public int CurrentStep
    {
        get => _currentStep;
        set => this.RaiseAndSetIfChanged(ref _currentStep, value);
    }

    public UnitSystem SelectedUnitSystem
    {
        get => _selectedUnitSystem;
        set => this.RaiseAndSetIfChanged(ref _selectedUnitSystem, value);
    }
    
    public string Name
    {
        get => _name;
        set => this.RaiseAndSetIfChanged(ref _name, value);
    }

    public string LastName
    {
        get => _lastName;
        set => this.RaiseAndSetIfChanged(ref _lastName, value);
    }

    public double Height
    {
        get => _height;
        set => this.RaiseAndSetIfChanged(ref _height, value);
    }

    public double Width
    {
        get => _width;
        set => this.RaiseAndSetIfChanged(ref _width, value);
    }

    public int Age
    {
        get => _age;
        set => this.RaiseAndSetIfChanged(ref _age, value);
    }

    public Gender Gender
    {
        get => _gender;
        set => this.RaiseAndSetIfChanged(ref _gender, value);
    }
    
    // Usa ICommand - es más simple y compatible
    public ICommand NextCommand { get; }
    public ICommand PreviousCommand { get; }
    public ICommand FinishCommand { get; }

    public WelcomeViewModel()
    {
        NextCommand = ReactiveCommand.Create(() => CurrentStep++);
        PreviousCommand = ReactiveCommand.Create(() => CurrentStep--);
        FinishCommand = ReactiveCommand.Create(() => { });
    }
}