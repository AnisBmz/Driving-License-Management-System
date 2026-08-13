using DVLD_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DVLD_System.Global_Classes
{
    public class clsUtil
    {
        static private void _CreateFolderIfDoesNotExist(string destinationFile)
        {

            if (!Directory.Exists(destinationFile))
            {
                Directory.CreateDirectory(destinationFile);
            }

        }

        static private string _GenerateGUID() { 
        
            return Guid.NewGuid().ToString();

        }

        static private string _ReplaceFileNameWithGUID(string sourceFile)
        {

            FileInfo fileInfo = new FileInfo(sourceFile);
            string extn = fileInfo.Extension;
            return _GenerateGUID() + extn;

        }

        static public bool CopyImageToPeopleImagesFolder(string sourceFile, ref string destinationFile)
        {

            string destinationFolder = @"C:\DVLD_People_Images\";

            clsUtil._CreateFolderIfDoesNotExist(destinationFolder);

            string newDestinationFile = $@"{destinationFolder}{_ReplaceFileNameWithGUID(sourceFile)}";

            try
            {

                File.Copy(sourceFile, newDestinationFile, true);


            }
            catch (IOException iox)
            {

                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            destinationFile = newDestinationFile;
            return true;
        }

        static public void ValidateAndClearRememberMeData(clsUser user, clsUser currentUser)
        {

            string filePath = clsGlobalSettings.FilePath;

            if (File.Exists(filePath))
            {

                if (user.UserID == currentUser.UserID)
                {

                    if (user.Password != currentUser.Password || user.Username != currentUser.Username)
                    {

                        try
                        {
                            File.Delete(filePath);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }

                    }

                }
            }

        }

        static public void ClearRememberMeData()
        {

            string filePath = clsGlobalSettings.FilePath;

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }

        }

        private static string _Encrypt(string plainText, string key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32)); 
                aes.IV = new byte[16]; 

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] buffer = Encoding.UTF8.GetBytes(plainText);

                return Convert.ToBase64String(encryptor.TransformFinalBlock(buffer, 0, buffer.Length));
            }
        }

        private static string _Decrypt(string cipherText, string key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32));
                aes.IV = new byte[16];

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] buffer = Convert.FromBase64String(cipherText);

                return Encoding.UTF8.GetString(decryptor.TransformFinalBlock(buffer, 0, buffer.Length));
            }
        }

        static public void SaveCredentialsIfRememberMe(string username, string password, bool rememberMe)
        {

            string filePath = clsGlobalSettings.FilePath;

            try
            {

                if (rememberMe)
                {

                    string credentials = $"{username}|{_Encrypt(password, "MySecretKey123")}";
                    File.WriteAllText(filePath, credentials);

                }
                else
                {
                    if (File.Exists(filePath))
                    {

                        File.Delete(filePath);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        static public void LoadRememberMeCredentials(ref string username, ref string password, ref bool rememberMe)
        {

            string filePath = clsGlobalSettings.FilePath;


            if (File.Exists(filePath))
            {

                char separator = '|';

                try
                {

                    using (StreamReader streamReader = File.OpenText(filePath))
                    {

                        string loginInfo = streamReader.ReadLine();

                        if (!string.IsNullOrWhiteSpace(loginInfo))
                        {
                            string[] ArrLoginInfo = (loginInfo.Split(separator));

                            if (ArrLoginInfo.Length >= 2)
                            {

                                username = ArrLoginInfo[0].Trim() ;
                                password = _Decrypt(ArrLoginInfo[1].Trim(), "MySecretKey123");
                                rememberMe = true;

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                username = "";
                password = "";
                rememberMe = false;
            }

        }

    }
}
