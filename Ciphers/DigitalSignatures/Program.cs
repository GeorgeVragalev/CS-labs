using Ciphers.DigitalSignatures.App;
using Ciphers.DigitalSignatures.Authenticator;
using Ciphers.DigitalSignatures.DB;
using Ciphers.DigitalSignatures.Model;

namespace Ciphers.DigitalSignatures;

public class Program
{
    private readonly IClientApp _clientApp;

    private Program(IClientApp clientApp)
    {
        _clientApp = clientApp;
    }

    public static void DigitalSignatures()
    {
        var program = new Program(new ClientApp(new Authenticate(new PasswordHasher(16, 20), new UserStorage(new List<User?>()), new DSE.DSE("george"))));
        program._clientApp.RunAuthenticator();
    }
}