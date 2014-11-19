/*Write a program that encodes and decodes a string using given encryption key (cipher). 
 * The key consists of a sequence of characters. The encoding/decoding is done by performing 
 * XOR (exclusive or) operation over the first letter of the string with the first of the key,
 * the second – with the second, etc. When the last key character is reached, the next is the first.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class EncryptString
{
    static void Main()
    {
        Console.WriteLine("Write string to encrypt/decrypt: ");
        string str = Console.ReadLine();
        Console.WriteLine("Enter key for encrypt/decrypt:");
        string key = Console.ReadLine();
        int keyCount = 0;
        string encoded = "";
        string decoded = "";

        //Encoding
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
            {
                sb.Append(((char)(str[i] ^ key[keyCount])).ToString()); //xor on char of str and char of key
                keyCount++;
                if (keyCount == key.Length - 1)
                {
                    keyCount = 0;
                }
            }
            else
            {
                sb.Append(' ');
            }
        }
        encoded = sb.ToString();
        Console.WriteLine("Encoded : {0}", encoded);

        //Decoding
        sb = new StringBuilder();
        keyCount = 0;
        for (int i = 0; i < encoded.Length; i++)
        {
            if (encoded[i] != ' ')
            {
                sb.Append(((char)(encoded[i] ^ key[keyCount])).ToString());
                keyCount++;
                if (keyCount == key.Length - 1)
                {
                    keyCount = 0;
                }
            }
            else
            {
                sb.Append(' ');
            }
        }
        decoded = sb.ToString();
        Console.WriteLine("Decoded : {0}", decoded);
    }
}