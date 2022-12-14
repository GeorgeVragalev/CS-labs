namespace WebAuthentication.Ciphers;

public class Caesar : ICipher
{
    public static string? CipherText { get; set; }
    public string? Input { get; set; }
    public int Key { get; set; }

    public Caesar(string? input, int key)
    {
        Input = input;
        Key = key;
    }


    public string Encipher()
    {
        return GeneralEncryption(Input, Key, true);
    }

    public string Decipher()
    {
        return GeneralEncryption(CipherText, 26 - Key, false);
    }

    private string GeneralEncryption(string input, int key, bool encipher)
    {
        string output = string.Empty;

        foreach (char ch in input)
            output += Cipher(ch, 26 - key);

        if (encipher)
        {
            CipherText = output;
        }
        return output;
    }

    private char Cipher(char ch, int key)
    {
        if (!char.IsLetter(ch))
        {
            return ch;
        }

        char d = char.IsUpper(ch) ? 'A' : 'a';
        return (char) ((((ch + key) - d) % 26) + d);
    }
}