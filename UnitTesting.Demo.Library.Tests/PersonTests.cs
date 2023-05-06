using System.Collections;

namespace UnitTesting.Demo.Library.Tests;

[TestFixture]
public class PersonTests
{
    [Test]
    public void Constructor_WhenCalled_ShouldInitializeProperties()
    {
        // AAA

        // Arrange
        const string firstName = "Jan";
        const string lastName = "Kowalski";
        const int birthYear = 2000;

        // Act
        Person person = new Person(firstName, lastName, birthYear);

        // Assert
        Assert.AreEqual(firstName, person.FirstName, "checking FirstName");
        Assert.AreEqual(lastName, person.LastName, "checking LastName");
        Assert.AreEqual(birthYear, person.BirthYear, "checking BirthYear");
    }

    [Test]
    [Ignore("Replaced by the test new test")]
    public void FullName_WhenCalled_ShouldReturnProperName()
    {
        // Arrange
        const string firstName = "Jan";
        const string lastName = "Kowalski";
        const int birthYear = 2000;
        const string expectedFullName = $"{firstName} {lastName}";
        Person person = new Person(firstName, lastName, birthYear);

        // Act
        string fullName = person.FullName;

        // Assert
        Assert.AreEqual(expectedFullName, fullName);
    }

    [Test]
    [TestCase("Jan", "Kowalski")]
    [TestCase("Adam", "Nowak")]
    public void FullName_WhenCalled_ShouldReturnProperName(string firstName, string lastName)
    {
        // Arrange
        const int birthYear = 2000;
        string expectedFullName = $"{firstName} {lastName}";
        Person person = new Person(firstName, lastName, birthYear);

        // Act
        string fullName = person.FullName;

        // Assert
        Assert.AreEqual(expectedFullName, fullName);
    }

    [Test]
    //[TestCase(2000, 2021, 21)]
    //[TestCase(2000, 2018, 18)]
    //[TestCase(2000, 2001, 1)]
    [TestCaseSource(nameof(GetAge_TestData))]
    public void GetAge_WhenBirthYearIsBeforeOrEqualCurrentYear_ShouldCalculateProperAge(
        int birthYear, int currentYear, int expectedAge)
    {
        // Arrange
        const string firstName = "Jan";
        const string lastName = "Kowalski";
        Person person = new Person(firstName, lastName, birthYear);

        // Act
        int actualAge = person.GetAge(currentYear);

        // Assert
        Assert.AreEqual(expectedAge, actualAge);
    }

    private static IEnumerable GetAge_TestData
    {
        get
        {
            yield return new TestCaseData(2000, 2022, 22);
            yield return new TestCaseData(2000, 2018, 18);
            yield return new TestCaseData(2000, 2001, 1);
        }
    }
}