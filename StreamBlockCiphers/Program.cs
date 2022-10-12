using StreamBlockCiphers.ControlCiphers;
using StreamBlockCiphers.RC4;

namespace StreamBlockCiphers;

public class Program
{
    private readonly IControlCiphers _controlCiphers;


    public Program(IControlCiphers controlCiphers)
    {
        _controlCiphers = controlCiphers;
    }

    public static void Main()
    {
        var program = new Program(new ControlCiphers.ControlCiphers(new RC4.RC4(), new DSE.DSE()));
        program._controlCiphers.RunCiphers();
    }
}