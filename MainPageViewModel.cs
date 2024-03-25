using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SmallApp;

public class MainPageViewModel: ObservableObject
{
    private string someValue = "I work good.";
    public string SomeValue
    {
        get => someValue;
        set => SetProperty(ref someValue, value);
    }

    public ICommand ChangeText { get; }

    public MainPageViewModel()
    {
        ChangeText = new Command(() => SomeValue = "I am broken now.");
    }
}