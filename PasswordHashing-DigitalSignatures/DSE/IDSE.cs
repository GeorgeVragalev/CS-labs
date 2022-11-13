namespace PasswordHashing_DigitalSignatures.DSE;

public interface IDSE
{
    public string Encrypt(string plaintext);
    public string Decrypt(string ciphertext);
}