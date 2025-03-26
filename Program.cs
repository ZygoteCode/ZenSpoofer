using System;
using System.Security.Principal;

internal class Program
{
    static void Main()
    {
        Console.Title = "ZenSpoofer";
        Console.WriteLine(@"

  ______           _____                    __          
 |___  /          / ____|                  / _|         
    / / ___ _ __ | (___  _ __   ___   ___ | |_ ___ _ __ 
   / / / _ \ '_ \ \___ \| '_ \ / _ \ / _ \|  _/ _ \ '__|
  / /_|  __/ | | |____) | |_) | (_) | (_) | ||  __/ |   
 /_____\___|_| |_|_____/| .__/ \___/ \___/|_| \___|_|   
                        | |                             
                        |_| Made by https://github.com/ZygoteCode/                             

");

        if (!(new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator))
        {
            Logger.LogError("Failed to run ZenSpoofer. Run the program with Administrator privileges.");
            Console.ReadLine();
            return;
        }

        Logger.LogInfo("Welcome to ZenSpoofer, a new innovative solution for spoofing your hardware & software.");
        Logger.LogInfo("Press ENTER to start spoofing.");
        Console.ReadLine();
        Logger.LogInfo("Started spoofing hardware & software, please wait a while.");
        Spoofer.SpoofEverything();
        Logger.LogInfo("Finished spoofing process. Press ENTER to exit.");
        Console.ReadLine();
    }
}
