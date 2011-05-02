using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Ostblock.Cryptography.Transposition;

namespace Tests.Ostblock.Cryptography
{
    public class GartenzaunAlgorithmTests
    {
        [Test]
        public void GartenZaun_Decrypt_Correct()
        {
            var gartenZaunAlgorithm = new GartenZaunAlgorithm(new GartenzaunAlgService(2));
            string decrypt = gartenZaunAlgorithm.Encrypt("Hallo");
            Assert.AreEqual("hloal", decrypt);
        }

        [TestCase(2, "hallo")]
        [TestCase(3, "hallo")]
        public void GetArrayLengths(int length, string word)
        {
            char[][] arrays = new char[length][];
            decimal i = word.Length/(decimal)length;
            decimal floor = Math.Ceiling(i);
            
            for (int j = 0; j < length; j++)
            {
                if (j == 0)
                    arrays[j] = new char[(int) floor];
                else
                    arrays[j] = new char[(int) i];
            }

            Assert.True(arrays[0].Length + arrays[1].Length == word.Length);
        }
    }
}
