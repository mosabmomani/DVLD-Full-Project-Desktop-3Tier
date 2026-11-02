using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public static class clsGlobal
    {
        public static clsUser CurrentUser;
        public static bool RememberUserNameAndPasswordInRegistry(string userName, string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\MyDataLogin";

          


            string valueName = "LoginUserCurrent";
            string valueData = userName + "#//#" + password;

            try
            {
                Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"an error occared {ex.Message}");
               
            }
            return false;
        }
        public static bool GetSortedCredentialFromRegistry(ref string userName, ref string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\MyDataLogin";

            string valueName = "LoginUserCurrent";

            try
            {
                string value = Registry.GetValue(keyPath, valueName, null) as string;
                if (value != null)
                {
                    string[] valueData = value.Split(new string[] { "#//#" }, StringSplitOptions.None);
                    if (valueData.Length == 2)
                    {
                        userName = valueData[0];
                        password = valueData[1];
                        return true;
                    }

                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"an error occared {ex.Message}");
            }
            return false;
        }

        public static bool DeleteSortedCredentialFromRegistry()
        {

            string keyPath = @"SOFTWARE\MyDataLogin";

            string valueName = "LoginUserCurrent";


            try
            {

                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                    {
                        if (key != null)
                        {

                            key.DeleteValue(valueName,false);
                            return true;
                        }

                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccessException: Run the program with administrative privileges.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


           return false;
        }

    }


}
