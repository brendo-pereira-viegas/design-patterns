Application linux = new(new LinuxFactory());
Application windows = new(new WindowsFactory());
Console.WriteLine(linux.RenderUI());
Console.WriteLine(windows.RenderUI());
Console.ReadKey();