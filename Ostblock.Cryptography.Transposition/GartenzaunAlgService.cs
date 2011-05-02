using System;

namespace Ostblock.Cryptography.Transposition
{
    public class GartenzaunAlgService : IAlgService
    {
        private readonly int _numberoflines;

        public GartenzaunAlgService(int numberoflines)
        {
            _numberoflines = numberoflines;
        }

        public string Decrypt(string cleartext)
        {
            return string.Empty;
        }

        private char[][] GetLinesArray(string word)
        {
            char[][] arrays = new char[_numberoflines][];
            decimal i = word.Length / (decimal)_numberoflines;
            decimal floor = Math.Ceiling(i);

            for (int j = 0; j < word.Length; j++)
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
            char[][] linesArray = GetLinesArray(cleartext);
            for (int i = 0; i < cleartext.Length; i++)
            {
                char c = cleartext[i];
                linesArray[i%_numberoflines].SetValue(c, i%_numberoflines);
            }
            return "";
        }
    }
}