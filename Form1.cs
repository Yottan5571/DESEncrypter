using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace DESEncrypter
{
    public partial class Form1 : Form
    {
        const string secretKey = "??lU&?=v";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Do encrypt

            // Escape backup
            File.Copy(tbPath.Text, tbPath.Text + ".back", true);

            // For additional security Pin the key.
            GCHandle gch = GCHandle.Alloc(secretKey, GCHandleType.Pinned);

            byte[] bytearrayinput;

            try
            {
                // Read file
                using (FileStream fsEncrypted = new FileStream(tbPath.Text, FileMode.Open, FileAccess.Read))
                {
                    FileInfo size = new FileInfo(tbPath.Text); // Get file size
                    bytearrayinput = new byte[size.Length];

                    fsEncrypted.Read(bytearrayinput, 0, bytearrayinput.Length);

                }

                if (bytearrayinput.Length <= 0)
                {
                    return;
                }

                // Open output file
                using (FileStream fsEncrypted = new FileStream(tbPath.Text, FileMode.Create, FileAccess.ReadWrite))
                {
                    // Setup DES 
                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();

                    if (cbPaddingOption.Checked)
                    {
                        DES.Padding = PaddingMode.None; // Do not use padding in order to keep string hash
                    }

                    DES.Key = ASCIIEncoding.ASCII.GetBytes(secretKey);
                    DES.IV = ASCIIEncoding.ASCII.GetBytes(secretKey);
                    ICryptoTransform desencrypt = DES.CreateEncryptor();
                    using (CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write))
                    {
                        cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
                        cryptostream.Close();
                    }
                }
            }
            catch (Exception exp)
            {
                lbLog.Items.Add(string.Format("Failed to encrypt. {0}", exp.Message));
                gch.Free();
                return;
            }

            gch.Free();
            lbLog.Items.Add("Encrypt complete");
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Do decrypt
            byte[] byteData;

            // Setup DES 
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(secretKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(secretKey);


            if (cbPaddingOption.Checked)
            {
                DES.Padding = PaddingMode.None; // Do not use padding in order to keep string hash
            }

            // For additional security Pin the key.
            GCHandle gch = GCHandle.Alloc(secretKey, GCHandleType.Pinned);


            try
            {
                // Open encrypted file, decrypt and store to byteData
                using (FileStream fsRead = new FileStream(tbPath.Text, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    FileInfo size = new FileInfo(tbPath.Text); // Get file size
                    byteData = new byte[size.Length];

                    ICryptoTransform encrypt = DES.CreateDecryptor();
                    using (CryptoStream cryptostream = new CryptoStream(fsRead, encrypt, CryptoStreamMode.Read))
                    {
                        cryptostream.Read(byteData, 0, byteData.Length);
                    }
                }

                // Create and Clear all contains
                using (FileStream fsEnpty = new FileStream(tbPath.Text, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    fsEnpty.SetLength(0);
                }

                // Open and write plane text to output file
                using (FileStream fsTempFile = new FileStream(tbPath.Text, FileMode.Open, FileAccess.Write))
                {
                    // Get byte data
                    fsTempFile.Write(byteData, 0, byteData.Length);
                }
            }
            catch(Exception exp)
            {
                lbLog.Items.Add(string.Format("Failed to decrypt. {0}", exp.Message));
                gch.Free();
                return;
            }


            gch.Free();

            lbLog.Items.Add("Decrypt complete");
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            // Browse file find
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = tbPath.Text;

            DialogResult ret = dialog.ShowDialog();
            if (ret == DialogResult.OK)
            {
                tbPath.Text = dialog.FileName;
            }
        }

        private void btnGetHash_Click(object sender, EventArgs e)
        {
            // Get hash code
            using (StreamReader sr = new StreamReader(tbPath.Text))
            {
                char[] buff = new char[(int)sr.BaseStream.Length];
                sr.Read(buff, 0, (int)sr.BaseStream.Length);
                string ret = new string(buff);

                lbLog.Items.Add(string.Format("Hash code = {0}", ret.GetHashCode()));
            }

        }
    }
}
