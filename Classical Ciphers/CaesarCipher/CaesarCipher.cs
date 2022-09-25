namespace Classical_Ciphers.CaesarCipher;

public class CaesarCipher
{
    public static void Caesar()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Welcome to Caesar cipher!\n");

                Console.WriteLine("Type a string to encrypt: ");
                string? UserString = Console.ReadLine();

                Console.WriteLine("\n");

                Console.Write("Enter your Key (number): ");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");


                Console.WriteLine("Encrypted Data");
                var caesarCipher = new Caesar(UserString, key);
                string cipherText = caesarCipher.Encipher();
                Console.WriteLine(cipherText);
                Console.Write("\n");

                Console.WriteLine("Decrypted Data: ");

                string t = caesarCipher.Decipher();
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