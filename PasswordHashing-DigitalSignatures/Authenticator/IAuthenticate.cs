using PasswordHashing_DigitalSignatures.Model;

namespace PasswordHashing_DigitalSignatures.Authenticator;

public interface IAuthenticate
{
    public void Register();
    public User Login();
    public void SetDigitalSignature(User user);
    public void VerifyDigitalSignature(User user);
}