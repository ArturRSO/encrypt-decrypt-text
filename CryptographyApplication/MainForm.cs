using CryptographyApplication.Core;
using System;
using System.Windows.Forms;

namespace CryptographyApplication
{
    public partial class MainForm : Form
    {
        readonly Cryptography _cryptography;

        public MainForm()
        {
            InitializeComponent();
            _cryptography = new Cryptography();
        }

        private void BtnCrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtEncryptKey.Text;
                string text = txtToEncrypt.Text;

                int nKey = int.Parse(key);
                string rKey = nKey.ToString();

                string result = _cryptography.Encrypt(rKey, text);

                if(!String.IsNullOrEmpty(result))
                {
                    txtEncrypted.Text = result + Environment.NewLine + Environment.NewLine + "Encrypted with the key -> " + key;
                }
                else
                {
                    MessageBox.Show("You must type a key and a text to encrypt!");
                }  
            }
            catch (FormatException)
            {
                MessageBox.Show("Key must be a number!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ouch! Something went wrong and the message could not be encrypted.");
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtDecryptKey.Text;
                string text = txtToDecrypt.Text;

                int nKey = int.Parse(key);
                string rKey = nKey.ToString();

                string result = _cryptography.Decrypt(rKey, text);

                if (!String.IsNullOrEmpty(result))
                {
                    txtDecripted.Text = result;
                }
                else
                {
                    MessageBox.Show("You must type a key and a text to decrypt!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Key must be a number!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ouch! Something went wrong and the message could not be decrypted.");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDecripted.Text = String.Empty;
            txtDecryptKey.Text = String.Empty;
            txtEncrypted.Text = String.Empty;
            txtEncryptKey.Text = String.Empty;
            txtToDecrypt.Text = String.Empty;
            txtToEncrypt.Text = String.Empty;
        }
    }
}
