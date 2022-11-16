using System.Numerics;
using Ciphers.AsymmetricCiphers.ControlCiphers;

namespace Ciphers.AsymmetricCiphers.RSA;

public interface IRsaCipher : IRunCipher
{
    int Encrypt(int plainText);
    BigInteger Decrypt(int cipherText);
}