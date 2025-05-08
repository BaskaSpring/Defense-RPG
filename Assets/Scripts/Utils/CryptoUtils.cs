using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class CryptoUtils
{
    private static readonly string key = "MySecretKey12345"; // ִ־ֵֶֻֽ בûעü 16 סטלגמכמג (128 בטע)
    private static readonly string iv = "MyInitVector12345"; // ׂמזו 16 סטלגמכמג

    public static string Encrypt(string plainText)
    {
        using Aes aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.IV = Encoding.UTF8.GetBytes(iv);

        ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

        using MemoryStream ms = new();
        using CryptoStream cs = new(ms, encryptor, CryptoStreamMode.Write);
        using (StreamWriter sw = new(cs))
        {
            sw.Write(plainText);
        }

        return Convert.ToBase64String(ms.ToArray());
    }

    public static string Decrypt(string encryptedText)
    {
        using Aes aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.IV = Encoding.UTF8.GetBytes(iv);

        ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        byte[] buffer = Convert.FromBase64String(encryptedText);

        using MemoryStream ms = new(buffer);
        using CryptoStream cs = new(ms, decryptor, CryptoStreamMode.Read);
        using StreamReader sr = new(cs);
        return sr.ReadToEnd();
    }
}