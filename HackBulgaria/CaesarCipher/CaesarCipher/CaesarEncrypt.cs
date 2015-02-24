using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class CaesarEncrypt
    {
        static string CaesarEncrypt(string str, int n)
        {
            StringBuilder encrypted = new StringBuilder();
            string result;
            int length = str.Length;
            char[] lowerCase = new char[26];
            char[] upperCase = new char[26];
            int letters = lowerCase.Length;
            int currentLetter;

            for (int i = 0; i < letters; i++)
            {
                lowerCase[i] = (char)('a' + i);
                upperCase[i] = (char)('A' + i);
            }

            for (int i = 0; i < length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    currentLetter = (int)(str[i] - 'a') + n;
                    currentLetter %=  26;
                    encrypted.Append(lowerCase[currentLetter]);

                }
                else if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    currentLetter = (int)(str[i] - 'A') + n;
                    currentLetter %= 26;
                    encrypted.Append(upperCase[currentLetter]);
                }
            }

            result = encrypted.ToString();
            return result;
        }

        static void Main()
        {
            string str = CaesarEncrypt("XYZ", 1);
            Console.WriteLine(str);
        }
    }
}
