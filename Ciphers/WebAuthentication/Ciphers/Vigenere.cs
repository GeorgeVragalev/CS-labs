namespace WebAuthentication.Ciphers;

public class Vigenere 
{
    public static string? CipherText { get; set; }
    public string? Input { get; set; }
    public string? Key { get; set; }

    public Vigenere(string? key, string? input)
    {
        Key = key;
        Input = input;
    }

    private int Mod(int a, int b)
    {
        return (a % b + b) % b;
    }

    private string Cipher(string input, string? key, bool encipher)
    {
        for (int i = 0; i < key.Length; ++i)
            if (!char.IsLetter(key[i]))
                return null; // Error

        string output = string.Empty;
        int nonAlphaCharCount = 0;

        for (int i = 0; i < input.Length; ++i)
        {
            if (char.IsLetter(input[i]))
            {
                bool cIsUpper = char.IsUpper(input[i]);
                char offset = cIsUpper ? 'A' : 'a';
                int keyIndex = (i - nonAlphaCharCount) % key.Length;
                int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
                k = encipher ? k : -k;
                char ch = (char)((Mod(((input[i] + k) - offset), 26)) + offset);
                output += ch;
            }
            else
            {
                output += input[i];
                ++nonAlphaCharCount;
            }
        }
        if (encipher)
        {
            CipherText = output;
        }
        return output;
    }

    public string Encipher()
    {
        return Cipher(Input, Key, true);
    }

    public string Decipher()
    {
        return Cipher(CipherText, Key, false);
    }
}