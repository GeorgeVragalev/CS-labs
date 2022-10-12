using StreamBlockCiphers.ControlCiphers;

namespace StreamBlockCiphers.RC4;

public interface IRC4 : IRunCipher
{
    byte[] PseudoRandomRc4(int[] sBox, byte[] messageBytes);
}