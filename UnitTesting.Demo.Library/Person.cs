namespace UnitTesting.Demo.Library;

public class Person
{
    public string FirstName { get; }
    public string LastName { get; }
    public int BirthYear { get; }

    public Person(string firstName, string lastName, int birthYear)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthYear = birthYear;
    }

    public int GetAge(int currentYear)
    {
        if (BirthYear > currentYear)
        {
            throw new ArgumentException(nameof(currentYear));
        }

        return currentYear - BirthYear;
    }

    public string FullName => $"{FirstName} {LastName}";
}