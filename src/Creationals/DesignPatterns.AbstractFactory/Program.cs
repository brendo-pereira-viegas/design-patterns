Application linux = new(new LinuxFactory());
Application windows = new(new WindowsFactory());
linux.RenderUI();
windows.RenderUI();
Console.ReadKey();