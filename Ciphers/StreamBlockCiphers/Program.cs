using Ciphers.StreamBlockCiphers.ControlCiphers;

namespace Ciphers.StreamBlockCiphers;

public class Program
{
    private readonly IControlCiphers _controlCiphers;

    private Program(IControlCiphers controlCiphers)
    {
        _controlCiphers = controlCiphers;
    }

    public static void StreamBlockCiphers()
    {
        var program = new Program(new ControlCiphers.ControlCiphers(new RC4.RC4(), new DSE.DSE()));
        program._controlCiphers.RunCiphers();
    }
}