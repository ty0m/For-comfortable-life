using System;
using Microsoft.Win32;
namespace GameMode
{
    class Program
    {
        static void Main(string[] args)
        {
           SwitchHotKey();
        }

        static public void SwitchHotKey()
        {
            try
            {
                const string keyName = @"HKEY_CURRENT_USER\Keyboard Layout\Toggle";
                if ("1" == Registry.GetValue(keyName, "Hotkey", null).ToString())
                {
                    Registry.SetValue(keyName, "Hotkey", "3");
                    Registry.SetValue(keyName, "Language Hotkey", "3");
                }
                else if ("3" == Registry.GetValue(keyName, "Hotkey", null).ToString())
                {
                    Registry.SetValue(keyName, "Hotkey", "1");
                    Registry.SetValue(keyName, "Language Hotkey", "1");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
    
        }
    }
}
