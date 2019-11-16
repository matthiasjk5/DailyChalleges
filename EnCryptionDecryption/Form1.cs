using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnCryptionDecryption
{
    public partial class Form1 : Form
    {
        // 
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
        RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
        byte[] data;
        byte[] encryptData;
        public Form1()
        {
            InitializeComponent();
        }

        byte[] Encrypt(byte[] data, RSAParameters RSAKey, bool fOAEP)
        {
            byte[] encryptedData;
            using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
            {
                rSACryptoServiceProvider.ImportParameters(RSAKey);
                encryptedData = rSACryptoServiceProvider.Encrypt(data, fOAEP);
            }
            return encryptedData;
        }

        byte[] Decrypt(byte[] data, RSAParameters RSAKey, bool fOAEP)
        {
            byte[] decryptedData;
            using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
            {
                rSACryptoServiceProvider.ImportParameters(RSAKey);
                decryptedData = rSACryptoServiceProvider.Decrypt(data, fOAEP);
            }
            return decryptedData;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            data = unicodeEncoding.GetBytes(txtInput.Text);
            encryptData = Encrypt(data, rSACryptoServiceProvider.ExportParameters(false), false);
            txtEncrypt.Text = unicodeEncoding.GetString(encryptData);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            byte[] data = Decrypt(encryptData, rSACryptoServiceProvider.ExportParameters(true), false);
            txtDecrypt.Text = unicodeEncoding.GetString(data);
        }
    }
}
