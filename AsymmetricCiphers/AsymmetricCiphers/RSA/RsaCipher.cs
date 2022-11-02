
using System.Numerics;
namespace AsymmetricCiphers.RSA;

public class RsaCipher : IRsaCipher
{
    private int _d;
    private int _e;
    private readonly int _n;
    private readonly int _phi;

    public RsaCipher(int x, int y)
    {
        _n = x * y;
        _phi = (x - 1) * (y - 1);
    }

    public int Encrypt(int plainText)
    {
        for (_e = 2; _e < _phi; _e++)
        {
            if (Gcd(_e, _phi) == 1)
            {
                break;
            }
        }

        var ciphertext = (int) ((Math.Pow(plainText, _e)) % _n);

        return ciphertext;
    }

    public BigInteger Decrypt(int cipherText) {
        BigInteger decryptedText;

        for (int i = 0; i <= 9; i++) {
            int x = 1 + (i * _phi);
            if (x % _e == 0) {
                _d = x / _e;
                break;
            }
        }
        BigInteger N = (_n);
        BigInteger cipher = cipherText;

        decryptedText = BigInteger.ModPow(cipher, _d, N);

        return decryptedText;
    }

    private static int Gcd(int e, int phi)
    {
        return e == 0 ? phi : Gcd(phi % e, e);
    }

    public void RunCipher()
    {
        Console.WriteLine("*************************************************");
        Console.WriteLine(" RSA Algorithm - Encryption and Decryption      |");
        Console.WriteLine("*************************************************");

        Console.WriteLine("Enter Plaintext (integer) to Encrypt:");
        int plainText;
        try
        {
            plainText= Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        if (plainText<0)
            return;
        
        var encryptBytes = Encrypt(plainText);
        Console.WriteLine("RSA Encrypted: {0}", encryptBytes);
        
        var decryptedString = Decrypt(encryptBytes);
        Console.WriteLine("RSA Decrypted: {0}", decryptedString);
        Console.ReadLine();    
    }
}