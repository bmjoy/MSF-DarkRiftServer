# MSF-DarkRiftServer

[![patreon_logo](https://user-images.githubusercontent.com/1029673/28471651-be40a2ea-6e35-11e7-9b01-e1b4a7d533b3.png)](https://www.patreon.com/proepkes) 
[![Discord](https://img.shields.io/discord/413156098993029120.svg)](https://discord.gg/F9hJhcX) 

### Highlevel-view:

[![architecture](https://i.imgur.com/x4XIuvF.png)](https://i.imgur.com/x4XIuvF.png)

### Instructions:

1. Extract "DarkRift Server.rar" into the directory "Deploy"
1. Copy DarkRiftClient.dll, DarkRiftServer.dll and DarkRift.dll into the directory "Deploy"
1. Open "TundraServerPlugins.sln" in Visual Studio
1. Right-click on solution -> "Restore NuGet-Packages"
1. Check whether the settings in "Settings.settings" in the Project "Spawner" fit your needs
1. Build solution
1. Replace the contents of "Server.config" with the contents of "MasterServerExample.config" and configure accordingly
1. Run DarkRift.Server.Console.exe and then run Spawner.exe

### FAQ:

Deploying on Linux results in "System.ArgumentException: An item with the same key has already been added":
 - Delete DarkRiftServer.dll  from Plugins/ and WorldPlugins/
 
Why do the DarkRift-dlls have to be copied to the Deploy folder?:
 - When you run DarkRift.Server.Console.exe normally it acts as the MasterServer. If spawned by the Spawner, it acts as a Room/Gameserver and requires all dependencies inside the same directory (due to "Process.Start").

### Resources:

https://darkriftnetworking.com/

https://github.com/alvyxaz/barebones-masterserver

### Warning:

Even though this project is programmed with great care, I take no responsibility for any (security) issues. It's still in the very early development and there will be breaking changes every now and then. This project will be field-tested by my other projects.
