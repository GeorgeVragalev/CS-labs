using AsymmetricCiphers.ControlCiphers;
using AsymmetricCiphers.RSA;

namespace AsymmetricCiphers;

public class Program
{
    private readonly IControlCiphers _controlCiphers;

    public Program(IControlCiphers controlCiphers)
    {
        _controlCiphers = controlCiphers;
    }

    public static void Main(string[] args)
    {
        var program = new Program(new ControlCiphers.ControlCiphers(new RsaCipher(79, 13)));
        program._controlCiphers.RunCiphers();
    }
}