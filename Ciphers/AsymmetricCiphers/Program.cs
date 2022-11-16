using Ciphers.AsymmetricCiphers.ControlCiphers;
using Ciphers.AsymmetricCiphers.RSA;

namespace Ciphers.AsymmetricCiphers;

public class Program
{
    private readonly IControlCiphers _controlCiphers;

    private Program(IControlCiphers controlCiphers)
    {
        _controlCiphers = controlCiphers;
    }

    public static void AsymmetricCiphers()
    {
        var program = new Program(new ControlCiphers.ControlCiphers(new RsaCipher(3, 11)));
        program._controlCiphers.RunCiphers();
    }
}