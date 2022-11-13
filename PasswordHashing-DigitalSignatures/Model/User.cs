namespace PasswordHashing_DigitalSignatures.Model;

public class User : Entity
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Message { get; set; }

    public void GetDetails()
    {
        Console.WriteLine($"Id: {Id} |  UserName: {UserName}  |   Password: {Password}  |  Message: {Message}");
    }
}