namespace Ciphers.ClassicalCiphers.PlayfairCipher;

public class PlayfairCipher
{
    public static void Playfair()
    {
        Console.WriteLine("Welcome to Playfair cipher!\n");

        while (true)
        {
            try
            {
                Console.WriteLine("Type a string to encrypt: ");
                string? UserString = Console.ReadLine();

                Console.WriteLine("\n");

                Console.Write("Enter your Key (string): ");
                string? key = Console.ReadLine();
                Console.WriteLine("\n");


                Console.WriteLine("Encrypted Data");
                var vigenere = new Playfair(key, UserString);
                string cipherText = vigenere.Encipher();
                Console.WriteLine(cipherText);
                Console.Write("\n");

                Console.WriteLine("Decrypted Data: ");

                string t = vigenere.Decipher();
                Console.WriteLine(t);
                Console.Write("\n");

                Console.WriteLine("Do you wish to continue? (y) or (n): ");

                var continueOn = Console.ReadLine();
                if (continueOn.ToLower().Equals("n"))
                {
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("invalid input \n");
                continue;
            }
        }
    }
}