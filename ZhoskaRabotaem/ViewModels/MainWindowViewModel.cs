using System.Collections.Generic;
using System.Collections.ObjectModel;
using ZhoskaRabotaem.Models;
namespace ZhoskaRabotaem.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ObservableCollection<Person> _people;
    public ObservableCollection<Person> People
    {
        get { return _people; }
        set
        {
            _people = value;
            OnPropertyChanged(nameof(People));
        }
    }


    public MainWindowViewModel()
    {
        var people = new List<Person> 
        {
            new Person("John", "Doe", 25),
            new Person("Alice", "Johnson", 30),
            new Person("Bob", "Smith", 42),
            new Person("Emily", "Williams", 28),
            new Person("Michael", "Brown", 35),
            new Person("Olivia", "Jones", 31),
            new Person("David", "Miller", 39),
            new Person("Sophia", "Davis", 45),
            new Person("Daniel", "Anderson", 27),
            new Person("Mia", "Martinez", 33),
            new Person("Ethan", "Garcia", 29),
            new Person("Ava", "Rodriguez", 36),
            new Person("Christopher", "Taylor", 41),
            new Person("Emma", "Moore", 34),
            new Person("Matthew", "Hernandez", 37),
            new Person("Isabella", "Lopez", 43),
            new Person("Andrew", "Wilson", 26),
            new Person("Grace", "White", 32),
            new Person("Ryan", "Clark", 40),
            new Person("Chloe", "Turner", 38),
            new Person("Jacob", "Perez", 44),
            new Person("Lily", "Hall", 55),
            new Person("Nicholas", "Young", 48),
            new Person("Hannah", "Lee", 50),
            new Person("William", "Lewis", 46),
            new Person("Madison", "Wright", 52),
            new Person("Alexander", "Walker", 47),
            new Person("Samantha", "Allen", 49),
            new Person("Logan", "Baker", 51),
            new Person("Ella", "Harris", 53)

            
        };
        People = new ObservableCollection<Person>(people);
    }
}