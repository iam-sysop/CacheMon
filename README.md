# CacheMon
### Windows 10 Standby Cache Monitor and Flusher

Windows 8 and 10 includes a VERY AGGRESSIVE file/memory caching system.  During idle periods, the OS will tend to populate this Standby Cache with data based on your app and file usage.  In many circumstances, this cache will consume ALL free physical RAM, and even though Windows is supposed to cast this data away, many instances see high swapping issues instead, with Windows refusing to let go of the cached files in memory - leading to degraded performance.

This application tries to mitigate this via polling various memory counters, and using a configured threshold, will flush the Standby Cache when free RAM as well as Standby List consumption both reach a trigger.

This is an x64 application ONLY.  Windows 10 is a RAM monster.  8GB will get you by, but 16GB is REALLY what you need if you're a "daily driver" on your machine.  Much more if you are into intensive usage such as gaming.  Regardless, under low memory situations, this app can help increase performance by automatically flushing the Standby Cache when it tries to consume ALL available resources.

**_Note_**  
"Aggressive Mode" is intended as a tool to free "more RAM" but it does so by attempting to trim Working Sets from all running processes.  This can cause said processes to instantly re-load their needed resources (which can be a performance hit) - while others may leave them freed if idling.  This mode can also cause exceptions due to permissions and protected processes.  This is a feature in progress - recommended to leave unchecked.


### Running CacheMon

CacheMon is portable - but requires .NET Framework v4.5.2 on the machine.  It also will request Administrator rights - needed to make calls to Win32 Memory Management.

When you run CacheMon - it runs from the System Tray - you may need to "Show all icons" in your taskbar.  Double-click the "chip" icon will bring up the main window.  It should be fine with default settings, but you can tune as needed.  

CacheMon is built to basically not need "any" intervention.  You can place a shortcut to the app in your startup items folder to get it to auto-start on login.



Developed in Visual Studio 2019 Community.  
Built against .Net Framework v4.5.2
