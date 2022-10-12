using StreamBlockCiphers.ControlCiphers;

namespace StreamBlockCiphers.DSE;

public interface IDSE : IRunCipher
{
    public string Encrypt(string plaintext, string key);
    public string Decrypt(string ciphertext, string key);
}