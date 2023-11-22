using System.Collections.Generic;
using System.Collections.ObjectModel;
using ZhoskaRabotaem.Models;
namespace ZhoskaRabotaem.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Person> People { get; }

    public MainWindowViewModel()
    {
        var people = new List<Person> 
        {
            new Person("Neil", "Armstrong",  55),
            new Person("Buzz", "Lightyear", 38),
            new Person("James", "Kirk", 44),
            new Person("Neil", "Armstrong",  55),
            new Person("Buzz", "Lightyear", 38),
            new Person("James", "Kirk", 44),
            new Person("Neil", "Armstrong",  55),
            new Person("Buzz", "Lightyear", 38),
            new Person("James", "Kirk", 44),
            new Person("Neil", "Armstrong",  55),
            new Person("Buzz", "Lightyear", 38),
            new Person("James", "Kirk", 44),
            new Person("Neil", "Armstrong",  55),
            new Person("Buzz", "Lightyear", 38),
            new Person("James", "Kirk", 44),
            new Person("Neil", "Armstrong",  55),
            new Person("Buzz", "Lightyear", 38),
            new Person("James", "Kirk", 44),
            new Person("Neil", "Armstrong",  55),
            new Person("Buzz", "Lightyear", 38),
            new Person("James", "Kirk", 44)
            
        };
        People = new ObservableCollection<Person>(people);
    }
}