using UnitTesting.Demo.Library;

Person person = new Person("Jan", "Kowalski", 2000);
Console.WriteLine(person.FirstName);
Console.WriteLine(person.LastName);
Console.WriteLine(person.GetAge(2021));
Console.WriteLine(person.FullName);
