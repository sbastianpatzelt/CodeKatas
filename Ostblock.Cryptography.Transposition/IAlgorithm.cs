namespace Ostblock.Cryptography.Transposition
{
    public interface IAlgorithm
    {
        string Decrypt(string secretText);
        string Encrypt(string clearText);
    }
}
