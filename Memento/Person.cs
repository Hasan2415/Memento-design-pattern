public class Person
{
    private List<Snapshot> _snapshots = new List<Snapshot>();
    public string Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }

    private Person(string firstName, string lastName, string email)
    {
        Id = Guid.NewGuid().ToString();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public static Person Create(string firstName, string lastName, string email)
    {
        return new Person(firstName, lastName, email);
    }

    public void Edit(string firstName, string lastName, string email)
    {
        _snapshots.Add(CreateSnapshot());
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public void Restore()
    {
        var lastPerson = _snapshots.Last();
        FirstName = lastPerson.FirstName;
        LastName = lastPerson.LastName;
        Email = lastPerson.Email;
    }

    private Snapshot CreateSnapshot()
    {
        return new Snapshot
        {
            FirstName = FirstName,
            LastName = LastName,
            Email = Email
        };
    }
}
