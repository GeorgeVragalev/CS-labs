namespace Ciphers.ClassicalCiphers.TranspositionCipher;

public interface ITransposition
{
    public string Decipher(string input, string key);
    public string Encipher(string input, string key, char padChar);
}