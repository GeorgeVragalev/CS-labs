using System.Numerics;
using AsymmetricCiphers.ControlCiphers;

namespace AsymmetricCiphers.RSA;

public interface IRsaCipher : IRunCipher
{
    int Encrypt(int plainText);
    BigInteger Decrypt(int cipherText);
}