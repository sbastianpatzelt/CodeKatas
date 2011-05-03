using NUnit.Framework;
using Ostblock.Cryptography.Transposition;
using Ostblock.Cryptography.Transposition.Interfaces;

namespace Tests.Ostblock.Cryptography
{
    [TestFixture]
    public class VigenereAlgorythmTests
    {
        [Test]
        public void GetLetter()
        {
            string a = "dasalphabetwechseltstaendig";
            var b = new PrimitiveAlgorithmType<string>("KEYKEYKEYKEYKEYKEYKEYKEYKEY".ToLower());

            IVigenereAlgorythm algorithm = new VigenereAlgorythm();
            algorithm.InitialVector = b;
            var result = algorithm.Encrypt(a);

            Assert.AreEqual("NEQKPNREZOXUOGFCIJDWRKILNME".ToLower(), result);
        }
    }
}