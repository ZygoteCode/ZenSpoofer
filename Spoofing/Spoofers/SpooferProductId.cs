using System;
using System.Text;
using Microsoft.Win32;

public static class SpooferProductId
{
    public static void Spoof()
    {
        string oldValue = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductId", null);

        if (oldValue == null)
        {
            Logger.LogError("Failed to change the value of 'Product Id'.");
            return;
        }

        try
        {
            string newValue = Utils.RandomInt(5).ToString() + "-" + Utils.RandomInt(5).ToString() + "-" + Utils.RandomInt(5).ToString() + "-" + Utils.RandomUpperNumbers(5);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductId", newValue);
            Logger.LogInfo("Succesfully changed 'Product Id' from '" + oldValue + "' to '" + newValue + "'.");
        }
        catch
        {
            Logger.LogError("Failed to change the value of 'Product Id'.");
        }
    }
}