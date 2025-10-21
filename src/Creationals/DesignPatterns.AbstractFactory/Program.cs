Application appLinux = new(new LinuxFactory());
Application appWindows = new(new WindowsFactory());
appLinux.RenderUI();
appWindows.RenderUI();
Console.ReadKey();