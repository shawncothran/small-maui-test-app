using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SmallApp;

public class MainPageViewModel: ObservableObject
{
    private string someValue = "I display the correct TextColor.";
    public string SomeValue
    {
        get => someValue;
        set => SetProperty(ref someValue, value);
    }

    public ICommand ChangeText { get; }

    public MainPageViewModel()
    {
        ChangeText = new Command(() => SomeValue = "I have broken TextColor.");
    }
}