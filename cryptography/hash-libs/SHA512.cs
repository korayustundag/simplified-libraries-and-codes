using System;
using System.IO;
using System.Text;

namespace hashlibs
{
    public class SHA512
    {
        /// <summary>
        /// It returns the entered data as SHA512 Hash.
        /// </summary>
        /// <param name="content">Text in string value to be converted to SHA512.</param>
        /// <returns>SHA512 output will be returned.</returns>
        public string Create(string content)
        {
            System.Security.Cryptography.SHA512 ee = new System.Security.Cryptography.SHA512CryptoServiceProvider();
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
        /// It is used to calculate the SHA512 Hash data of the file in the specified location.
        /// </summary>
        /// <param name="file">The location of the file in string value.</param>
        /// <returns>SHA512 output of the file will be returned.</returns>
        public string FileFingerprint(string file)
        {
            System.Security.Cryptography.SHA512 ee = new System.Security.Cryptography.SHA512CryptoServiceProvider();
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
