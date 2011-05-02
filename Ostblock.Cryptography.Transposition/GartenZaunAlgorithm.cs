using System;

namespace Ostblock.Cryptography.Transposition
{
    public class GartenZaunAlgorithm : IAlgorithm
    {
        private readonly IAlgService _algService;

        public GartenZaunAlgorithm(IAlgService algService)
        {
            _algService = algService;
        }

        public string Decrypt(string cleartext)
        {
            return _algService.Decrypt(cleartext);
        }

        public string Encrypt(string secretText)
        {
            return _algService.Encrypt(secretText);
        }
    }
}