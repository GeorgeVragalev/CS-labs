using Ciphers.ClassicalCiphers;

namespace Ciphers;

public static class MainProgram
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Cryptography!\n");

        
        var terminate = false;
        while (!terminate)
        {
            Console.Write("Select topic:" +
                          " \n (1) Classical Ciphers" +
                          " \n (2) Asymmetric Ciphers" +
                          " \n (3) Stream Block Ciphers" +
                          " \n (4) Digital Signatures and Password hashing" +
                          " \n (5) Quit \n"
            );
            int cipher = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (cipher)
            {
                case 1:
                    Program.ClassicalCiphers();
                    break;
                case 2:
                    AsymmetricCiphers.Program.AsymmetricCiphers();
                    break;
                case 3:
                    StreamBlockCiphers.Program.StreamBlockCiphers();
                    break;
                case 4:
                    DigitalSignatures.Program.DigitalSignatures();
                    break;
                case 5:
                    terminate = true;
                    break;
                default:
                    break;
            }
        }
    }
}