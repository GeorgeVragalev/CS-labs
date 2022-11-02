
using AsymmetricCiphers.RSA;

namespace AsymmetricCiphers.ControlCiphers;

public class ControlCiphers : IControlCiphers
{
    private readonly IRsaCipher _rsaCipher;


    public ControlCiphers(IRsaCipher rsaCipher)
    {
        _rsaCipher = rsaCipher;
    }

    public void RunCiphers()
    {
        Console.WriteLine("Welcome to Symmetric Ciphers!\n");
        
        var terminate = false;
        while (!terminate)
        {
            Console.Write("Select the cipher you want to use:" +
                          " \n (1) RSA Asymmetric Cipher" +
                          " \n (2) Quit \n"
            );
            int cipher = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (cipher)
            {
                case 1:
                    _rsaCipher.RunCipher();
                    break;
                case 2:
                    terminate = true;
                    break;
                default:
                    break;
            }
        }
    }
}