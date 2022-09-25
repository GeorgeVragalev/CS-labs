namespace Classical_Ciphers.TranspositionCipher;

public class TranspositionCipher
{
    public static void Transposition()
    {
        Console.WriteLine("Welcome to Transposition cipher!\n");

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
                
                Console.Write("Enter your padding character (char): ");
                char pad = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Encrypted Data");
                var vigenere = new Transposition();
                string cipherText = vigenere.Encipher(UserString, key, pad);
                Console.WriteLine(cipherText);
                Console.Write("\n");

                Console.WriteLine("Decrypted Data: ");

                string t = vigenere.Decipher(cipherText, key);
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