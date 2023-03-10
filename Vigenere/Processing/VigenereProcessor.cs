using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbcHashEks.Vigenere.Processing
{
    public class VigenereProcessor
    {
        private char[] alphabet;
        private char[,] cipherArray;

        public VigenereProcessor()
        {

        }

        public string DecryptMessage(string input, string codeKey)
        {
            // IMPORTANT
            input = input.ToUpper();
            codeKey = codeKey.ToUpper();

            char[] codeKeyArray = new char[input.Length];

            int originalKeyIndex = 0;

            for (int i = 0; i < codeKeyArray.Length; i++)
            {
                if (originalKeyIndex >= codeKey.Length) originalKeyIndex = 0;
                codeKeyArray[i] = codeKey[originalKeyIndex];

                originalKeyIndex++;
            }

            char[] outputString = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int line = GetCharArrayIndex(codeKeyArray[i]);
                outputString[i] = alphabet[FindWhateverIdk(line, input[i])];
            }

            return new string(outputString);
        }

        private int FindWhateverIdk(int line, char tofind)
        {
            for (int i = 0; i < 26; i++)
            {
                if (cipherArray[line, i] == tofind)
                {
                    return i;
                }
            }

            return -1;
        }

        public string EncryptMessage(string input, string codeKey)
        {
            // IMPORTANT
            input = input.ToUpper();
            codeKey = codeKey.ToUpper();

            char[] codeKeyArray = new char[input.Length];

            int originalKeyIndex = 0;

            for (int i = 0; i < codeKeyArray.Length; i++)
            {
                if (originalKeyIndex >= codeKey.Length) originalKeyIndex = 0;
                codeKeyArray[i] = codeKey[originalKeyIndex];

                originalKeyIndex++;
            }

            char[] outputString = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                outputString[i] = cipherArray[GetCharArrayIndex(codeKeyArray[i]), GetCharArrayIndex(input[i])];
            }

            return new string(outputString);

        }

        private int GetCharArrayIndex(char c)
        {
            return c - 65;
        }

        public void CreateArray()
        {
            CreateCipherArray();
        }

        private void CreateCipherArray()
        {
            if(alphabet is null)
            {
                CreateAlphabetArray();
            }

            cipherArray = new char[26, 26];

            // i = line
            // j = column
            for (int i = 0; i < 26; i++)
            {
                int alphabetIndex = i;

                for (int j = 0; j < 26; j++)
                {
                    if (alphabetIndex >= alphabet.Length)
                    {
                        alphabetIndex = 0;
                    }

                    cipherArray[i, j] = alphabet[alphabetIndex];
                    alphabetIndex++;
                }
            }
        }

        private void CreateAlphabetArray()
        {
            alphabet = new char[26];

            int j = 0;
            for (int i = 65; i < 91; i++)
            {
                alphabet[j] = (char)i;
                j++;
            }

        }
    }
}
