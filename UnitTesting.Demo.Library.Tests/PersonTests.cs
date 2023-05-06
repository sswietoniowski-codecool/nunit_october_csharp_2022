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
}