using System.Collections.Generic;

namespace Ostblock.Cryptography.Transposition
{
    public interface IAlgService
    {
        string Decrypt(string secretText);
        string Encrypt(string cleartext);
    }
}