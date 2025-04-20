using System;
using System.Text;
using Microsoft.Win32;

public static class SpooferComputerName
{
    public static void Spoof()
    {
        string oldValue = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\ComputerName\ComputerName", "ComputerName", null);

        if (oldValue == null)
        {
            Logger.LogError("Failed to change the value of 'Computer Name'.");
            return;
        }

        try
        {
            string newValue = "Desktop-" + Utils.RandomUpper(7);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\ComputerName\ComputerName", "ComputerName", newValue);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\ComputerName\ActiveComputerName", "ComputerName", newValue);
            Logger.LogInfo("Succesfully changed 'Computer Name' from '" + oldValue + "' to '" + newValue + "'.");
        }
        catch
        {
            Logger.LogError("Failed to change the value of 'Computer Name'.");
        }
    }
}