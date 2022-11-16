namespace Ciphers.ClassicalCiphers;

public static class Program
{
    public static void ClassicalCiphers()
    {
        Console.WriteLine("Welcome to Classical ciphers!\n");
        
        var terminate = false;
        while (!terminate)
        {
            Console.Write("Select the cipher you want to use:" +
                          " \n (1) Caesar Cipher" +
                          " \n (2) Vigenere Cipher" +
                          " \n (3) Playfair Cipher" +
                          " \n (4) Transposition Cipher" +
                          " \n (5) Quit \n"
            );
            int cipher = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (cipher)
            {
                case 1:
                    CaesarCipher.CaesarCipher.Caesar();
                    break;
                case 2:
                    VigenereCipher.VigenereCipher.Vigenere();
                    break;
                case 3:
                    PlayfairCipher.PlayfairCipher.Playfair();
                    break;
                case 4:
                    TranspositionCipher.TranspositionCipher.Transposition();
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