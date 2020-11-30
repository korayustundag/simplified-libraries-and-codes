using System;
using System.Text;
using System.IO;

namespace hashlibs
{
    public class SHA1
    {
        /// <summary>
        /// It returns the entered data as SHA1 Hash.
        /// </summary>
        /// <param name="content">Text in string value to be converted to SHA1.</param>
        /// <returns>SHA1 output will be returned.</returns>
        public string Create(string content)
        {
            System.Security.Cryptography.SHA1 ee = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            ee.ComputeHash(UTF8Encoding.UTF8.GetBytes(content));
            byte[] result = ee.Hash;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// It is used to calculate the SHA1 Hash data of the file in the specified location.
        /// </summary>
        /// <param name="file">The location of the file in string value.</param>
        /// <returns>SHA1 output of the file will be returned.</returns>
        public string FileFingerprint(string file)
        {
            System.Security.Cryptography.SHA1 ee = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            ee.ComputeHash(File.ReadAllBytes(file));
            byte[] result = ee.Hash;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}