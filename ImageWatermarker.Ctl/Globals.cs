// ***********************************************************************
// Assembly         : ImageCopyrightCtrl
// Author           : Jason Nowicki
// Created          : 08-11-2018
//
// Last Modified By : jason
// Last Modified On : 08-12-2018
// ***********************************************************************
// <copyright file="Globals.cs" company="">
// </copyright>
// ***********************************************************************
using System;
using System.Security.Cryptography;
using System.IO;

namespace ImageCopyrightCtrl
{
    /// <summary>
    /// Class Globals.
    /// </summary>
    internal static class Globals
    {
        /// <summary>
        /// Gets or sets the reg key.
        /// </summary>
        /// <value>The reg key.</value>
        internal static string RegKey { get; set; }

        /// <summary>
        /// The key 192
        /// </summary>
        private static readonly byte[] Key192 = { 24, 164, 79, 111, 40, 143, 111, 133, 202, 40, 89, 211, 156, 126, 135, 16 };
        /// <summary>
        /// The iv 192
        /// </summary>
        private static readonly byte[] Iv192 = { 166, 129, 143, 139, 114, 198, 3, 20, 108, 193, 190, 143, 14, 20, 190, 86 };

        /// <summary>
        /// Sets the initialize value.
        /// </summary>
        internal static void SetInitValue()
        {
            Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKey, true);
            reg.SetValue("IWMFTR", EncryptAes("0"));
        }

        /// <summary>
        /// Processes the image.
        /// </summary>
        internal static void ProcessImage()
        {
            Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKey, true);
            int i = Convert.ToInt32(DecryptAes(Convert.ToString(reg.GetValue("IWMFTR"))));
            reg.SetValue("IWMFTR", EncryptAes((i + 1).ToString()));
        }

        /// <summary>
        /// Gets the processed image count.
        /// </summary>
        /// <returns>System.Int32.</returns>
        internal static int GetProcessedImageCount()
        {
            Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKey, true);

            if (reg.GetValue("IWMFTR") == null)
            {
                SetInitValue();
            }

            return Convert.ToInt32(DecryptAes(Convert.ToString(reg.GetValue("IWMFTR"))));
        }


        /// <summary>
        /// Provides Standard 192 bit (AES) Encryption with a ramdomly selected key, and Initialization Vector
        /// </summary>
        /// <param name="value">The value you want to Encrypt</param>
        /// <returns>System.String.</returns>
        private static string EncryptAes(string value)
        {
            string str = "";
            if (value.Length <= 0)
            {
                return str;
            }

            RijndaelManaged aes = new RijndaelManaged();
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(Key192, Iv192), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);

            sw.Write(value);
            sw.Flush();
            cs.FlushFinalBlock();
            ms.Flush();

            str = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
            return str;
        }

        /// <summary>
        /// Provides Standard 192 bit (AES) Decryption with a ramdomly selected key, and Initialization Vector
        /// </summary>
        /// <param name="value">The value you want to Decrypt</param>
        /// <returns>System.String.</returns>
        private static string DecryptAes(string value)
        {
            string str = "";
            if (value.Length <= 0)
            {
                return str;
            }
            RijndaelManaged aes = new RijndaelManaged();
            byte[] buffer = Convert.FromBase64String(value);
            MemoryStream ms = new MemoryStream(buffer);
            CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(Key192, Iv192), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            str = sr.ReadToEnd();
            sr.Close();
            return str;
        }

    }

}