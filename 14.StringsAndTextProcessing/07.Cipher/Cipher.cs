using System;
using System.Text;

class Cipher
{
    static void Main()
    {
        string text = "Then this ebony bird beguiling my sad fancy into smiling, By the grave and stern decorum of the countenance it wore, \"Though thy crest be shorn and shaven, thou,\" I said, \"art sure no craven, Ghastly grim and ancient Raven wandering from the Nightly shore — Tell me what thy lordly name is on the Night's Plutonian shore!\" Quoth the Raven \"Nevermore.\"";
        string key = "raven";

        Console.WriteLine("Encrypted: ");
        Console.WriteLine(Encrypt(text, key));
        Console.WriteLine("\nDecrypted: ");
        Console.WriteLine(Decrypt(Encrypt(text, key), key));
    }

    static string Encrypt(string text, string key)
    {
        var encryptedText = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            encryptedText.Append((char)(text[i] ^ key[i % key.Length]));
        }

        return encryptedText.ToString();
    }

    static string Decrypt(string text, string key)
    {
        return Encrypt(text, key);
    }
}