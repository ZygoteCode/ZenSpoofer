using System;
using System.Text;
using Microsoft.Win32;

public static class SpooferMachineGuid
{
    public static void Spoof()
    {
        string oldValue = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography", "MachineGuid", null);

        if (oldValue == null)
        {
            Logger.LogError("Failed to change the value of 'Machine Guid'.");
            return;
        }

        try
        {
            string newValue = Guid.NewGuid().ToString();
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography", "MachineGuid", newValue);
            Logger.LogInfo("Succesfully changed 'Machine Guid' from '" + oldValue + "' to '" + newValue + "'.");
        }
        catch
        {
            Logger.LogError("Failed to change the value of 'Machine Guid'.");
        }
    }
}