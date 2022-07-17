Console.WriteLine("Start for create object :");
var person = Person.Create("Hasan", "rezaei", "hasan@gmail.com");

Console.WriteLine($"first name : {person.FirstName} ; " +
    $"last name : {person.LastName} ; " +
    $"email : {person.Email}");

Console.WriteLine();
Console.WriteLine("Start for edit object : ");
person.Edit("ali", "yaghobi", "ali@gmail.com");

Console.WriteLine($"first name : {person.FirstName} ; " +
    $"last name : {person.LastName} ; " +
    $"email : {person.Email}");

Console.WriteLine();
Console.WriteLine("Start for restore object :");
person.Restore();

Console.WriteLine($"first name : {person.FirstName} ; " +
    $"last name : {person.LastName} ; " +
    $"email : {person.Email}");
