using System;
using System.Collections.Generic;
using System.Linq;
using Ostblock.Cryptography.Transposition.Interfaces;

namespace Ostblock.Cryptography.Transposition
{
    public class VigenereAlgorythm : IVigenereAlgorythm
    {
        #region IAlgorithm<string> implementation
        public string Decrypt(string secretText)
        {
            throw new NotImplementedException();
        }


        public string Encrypt(string clearText)
        {
            var alpha = GetAlpha();
            var result = clearText.Select((x,i) =>
                                              {
                                                  var indexA = alpha.IndexOf(x);
                                                  var indexB = InitialVector.IntialVector[i];
                                                  var currentAlpha = ShiftAlpha( new string(indexB,1));
                                                  return currentAlpha.Skip(indexA).First();
                                              });

            return new string(result.ToArray());
        }

        private List<char> GetAlpha()
        {
            return new List<char>(new char[26].Select((a, b) => (char)(b + 97)));
        }


        public IInitialVector<string> InitialVector
        {
            get;
            set;
        }

        #endregion


        private IEnumerable<char> ShiftAlpha(string cipher)
        {
            var alpha = GetAlpha();
            var startIndex = alpha.IndexOf(Convert.ToChar(cipher));

            var alphaNew = new char[alpha.Count];
            alpha.CopyTo(alphaNew);

            alpha.InsertRange(alpha.Count, alphaNew.Take(startIndex));
            return alpha.Skip(startIndex).ToList();
        }

    }
}