namespace ProjectTracker.Domain.Users;
public sealed class User
{
    private User() { }

    public Guid Id { get; private set; }
    public string Name { get; private set; }

    public static User Create(string name)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = name
        };

        return user;
    }
}
