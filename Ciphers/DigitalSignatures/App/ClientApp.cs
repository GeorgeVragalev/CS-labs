using Ciphers.DigitalSignatures.Authenticator;
using Ciphers.DigitalSignatures.Model;

namespace Ciphers.DigitalSignatures.App;

public class ClientApp : IClientApp
{
    private readonly IAuthenticate _authenticate;

    public ClientApp(IAuthenticate authenticate)
    {
        _authenticate = authenticate;
    }

    public void RunAuthenticator()
    {
        Console.WriteLine("Welcome to Symmetric Ciphers!\n");

        var terminate = false;
        User loggedInUser = null;
        while (!terminate)
        {
            Console.Write("Select what you want to do:" +
                          " \n (1) Register" +
                          " \n (2) Login" +
                          " \n (3) Logout" +
                          " \n (4) Set Digital signature" +
                          " \n (5) Verify digital signature" +
                          " \n (6) Quit \n"
            );
            int cipher = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (cipher)
            {
                case 1:
                    _authenticate.Register();
                    break;
                case 2:
                    Console.WriteLine("You logged in successfully");
                    loggedInUser = _authenticate.Login();
                    break;
                case 3:
                    Console.WriteLine("You logged out successfully");
                    loggedInUser = null;
                    break;
                case 4:
                    if (loggedInUser != null)
                    {
                        _authenticate.SetDigitalSignature(loggedInUser);
                    }
                    break;
                case 5:
                    if (loggedInUser != null)
                    {
                        _authenticate.VerifyDigitalSignature(loggedInUser);
                    }
                    break;
                case 6:
                    terminate = true;
                    break;
                default:
                    break;
            }
        }
    }
}