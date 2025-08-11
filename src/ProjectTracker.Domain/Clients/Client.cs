namespace ProjectTracker.Domain.Clients;
public sealed class Client
{
    private Client() { }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public static Client Create(string name, string email, string phone)
    {
        Client client = new()
        {
            Id = Guid.NewGuid(),
            Name = name,
            Email = email,
            Phone = phone,
            CreatedAt = DateTime.Now // TODO: Replace with IDateTimeProvider
        };

        return client;
    }
}
