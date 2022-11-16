using Ciphers.StreamBlockCiphers.DSE;
using Ciphers.StreamBlockCiphers.RC4;

namespace Ciphers.StreamBlockCiphers.ControlCiphers;

public class ControlCiphers : IControlCiphers
{
    private readonly IRC4 _rc4;
    private readonly IDSE _dse;

    public ControlCiphers(IRC4 rc4, IDSE dse)
    {
        _rc4 = rc4;
        _dse = dse;
    }

    public void RunCiphers()
    {
        Console.WriteLine("Welcome to Symmetric Ciphers!\n");
        
        var terminate = false;
        while (!terminate)
        {
            Console.Write("Select the cipher you want to use:" +
                          " \n (1) RC4 Stream Cipher" +
                          " \n (2) DSE Block Cipher" +
                          " \n (3) Quit \n"
            );
            int cipher = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (cipher)
            {
                case 1:
                    _rc4.RunCipher();
                    break;
                case 2:
                    _dse.RunCipher();
                    break;
                case 3:
                    terminate = true;
                    break;
                default:
                    break;
            }
        }
    }
}