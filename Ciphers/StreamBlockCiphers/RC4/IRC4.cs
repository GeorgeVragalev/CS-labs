using Ciphers.StreamBlockCiphers.ControlCiphers;

namespace Ciphers.StreamBlockCiphers.RC4;

public interface IRC4 : IRunCipher
{
    byte[] PseudoRandomRc4(int[] sBox, byte[] messageBytes);
}