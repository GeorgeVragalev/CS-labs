using PasswordHashing_DigitalSignatures.App;
using PasswordHashing_DigitalSignatures.Authenticator;
using PasswordHashing_DigitalSignatures.DB;
using PasswordHashing_DigitalSignatures.Model;

namespace PasswordHashing_DigitalSignatures;

public class Program
{
    private readonly IClientApp _clientApp;

    private Program(IClientApp clientApp)
    {
        _clientApp = clientApp;
    }

    public static void Main(string[] args)
    {
        var program = new Program(new ClientApp(new Authenticate(new PasswordHasher(16, 20), new UserStorage(new List<User?>()), new DSE.DSE("george"))));
        program._clientApp.RunAuthenticator();
    }
}