using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Ostblock.Cryptography.Transposition;
using System.Collections.Generic;

namespace Tests.Ostblock.Cryptography
{
    [TestFixture]
    public class OctothorpeAlgorithmTests
    {

        [Test]
        public void alphaskip()
        {
            var c = new char[26].Select((a, b) => (char)((b % 26) + 97)).ToArray();
            Assert.True(c[0] == 'a');
        }

        [Test]
        public void a()
        {
            var cipher = "g";
            var c = new char[26].Select((a, b) => (char)((b % 26) + 97)).ToArray();

            for (int i = 0; i < c.Length; i++)
            {
                c = ShiftAlpha(new string((char)(i + 97), 1)).ToArray();
                for (int j = 0; j < c.Length; j++)
                {
                    Console.Out.Write(c[j]);
                }
                Console.WriteLine();
            }

            //List<char> toReturn = ShiftAlpha(cipher);

            //foreach (var x in toReturn)
            //{
            //    Console.Write(x);
            //}
            //Assert.AreEqual(26, toReturn.Count);
        }

        private List<char> ShiftAlpha(string cipher)
        {
            var alpha = new List<char>(new char[26].Select((a, b) => (char)(b + 97)).ToArray());
            var startIndex = alpha.IndexOf(Convert.ToChar(cipher));

            var alphaNew = new char[alpha.Count];
            alpha.CopyTo(alphaNew);

            alpha.InsertRange(alpha.Count, alphaNew.Take(startIndex));
            return alpha.Skip(startIndex).ToList();
        }

        [Test]
        public void SUT_Ascpect_Expectation()
        {
            var c = new char[26].Select((a, b) => (char)((b % 26) + 97)).ToArray();
            Assert.AreEqual('z', c[25]);
        }

        [Test]
        public void calc()
        {
            //0 26 52
            //1 27 53
            //2 28 54


            var b = 54;
            int buffer = ((b % 26) + 97);
            Console.WriteLine(buffer);
            Console.WriteLine(Convert.ToChar(buffer));
        }



        [Test]
        public void GartenZaun_Decrypt_Correct()
        {
            var gartenZaunAlgorithm = new OctothorpeAlgorithm(2);
            string decrypt = gartenZaunAlgorithm.Encrypt("hallo liebe omi");
            Assert.AreEqual("hloleeoial ib m", decrypt);
        }


        [Test]
        public void GartenZaun_DecryptThreeRows_Correct()
        {
            var gartenZaunAlgorithm = new OctothorpeAlgorithm(3);
            string decrypt = gartenZaunAlgorithm.Encrypt("hallo liebe omi");
            Assert.AreEqual("hllboaoieml e i", decrypt);
        }

        [TestCase(2, "hallo")]
        public void GetArrayLengths(int length, string word)
        {
            char[][] arrays = new char[length][];
            decimal i = word.Length / (decimal)length;
            decimal floor = Math.Ceiling(i);

            for (int j = 0; j < length; j++)
            {
                if (j == 0)
                    arrays[j] = new char[(int)floor];
                else
                    arrays[j] = new char[(int)i];
            }
            int aggregate = arrays.Aggregate(0, (b, a) => b + a.Length);

            Assert.True(aggregate == word.Length);
        }

    }
}