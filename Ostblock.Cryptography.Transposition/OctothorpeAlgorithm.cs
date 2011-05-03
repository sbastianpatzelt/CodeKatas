using System;
using System.Linq;
using Ostblock.Cryptography.Transposition.Interfaces;

namespace Ostblock.Cryptography.Transposition
{
    public class OctothorpeAlgorithm : IAlgorithm<int>
    {
        private readonly PrimitiveAlgorithmType<int> _primitiveAlgorithmType;

        public OctothorpeAlgorithm(int lines)
        {
            _primitiveAlgorithmType = new PrimitiveAlgorithmType<int>(lines);
        }

        public IInitialVector<int> InitialVector
        {
            get;set;
        }

        public string Decrypt(string cleartext)
        {
            return string.Empty;
        }

        private char[][] GetLinesArray(string word)
        {
            char[][] arrays = new char[_primitiveAlgorithmType.IntialVector][];
            decimal i = word.Length / (decimal)_primitiveAlgorithmType.IntialVector;
            decimal floor = Math.Ceiling(i);

            for (int j = 0; j < _primitiveAlgorithmType.IntialVector; j++)
            {
                if (j == 0)
                    arrays[j] = new char[(int)floor];
                else
                    arrays[j] = new char[(int)i];
            }
            return arrays;
        }

        public string Encrypt(string cleartext)
        {
            var linesArray = GetLinesArray(cleartext);
            for (var i = 0; i < cleartext.Length; i++)
            {
                var c = cleartext[i];
                linesArray[i%_primitiveAlgorithmType.IntialVector].SetValue(c, i / _primitiveAlgorithmType.IntialVector);
            }
            return linesArray
                .Aggregate(string.Empty, (s, a) => s + string.Join(string.Empty, a));
        }
    }
}