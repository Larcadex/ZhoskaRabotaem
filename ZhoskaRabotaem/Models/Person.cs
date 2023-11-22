namespace ZhoskaRabotaem.Models;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public int AgeInYears { get; set; }
    
    public int count { get; set; }
    
    public Person(string firstName , string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        AgeInYears = age;
        /*count = FirstName.Length;*/


    }
}