using System;
using System.Text;
using Microsoft.Win32;

public static class SpooferHwProfileGuid
{
    public static void Spoof()
    {
        string oldValue = (string) Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001", "HwProfileGuid", null);

        if (oldValue == null)
        {
            Logger.LogError("Failed to change the value of 'Hardware Profile Guid'.");
            return;
        }

        try
        {
            string newValue = "{" + Guid.NewGuid().ToString() + "}";
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001", "HwProfileGuid", newValue);
            Logger.LogInfo("Succesfully changed 'Hardware Profile Guid' from '" + oldValue + "' to '" + newValue + "'.");
        }
        catch
        {
            Logger.LogError("Failed to change the value of 'Hardware Profile Guid'.");
        }
    }
}