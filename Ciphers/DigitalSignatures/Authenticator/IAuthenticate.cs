using Ciphers.DigitalSignatures.Model;

namespace Ciphers.DigitalSignatures.Authenticator;

public interface IAuthenticate
{
    public void Register();
    public User Login();
    public void SetDigitalSignature(User user);
    public void VerifyDigitalSignature(User user);
}