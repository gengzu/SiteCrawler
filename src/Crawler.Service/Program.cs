using System;

public class Program
{
    public static void Main(string[] args)
    {
        var instanceId = args != null && args.Length > 0 ? args[0] : Guid.NewGuid().ToString();
        
        Console.WriteLine("Crawler Service started - " + instanceId);
        Console.WriteLine();
        Console.WriteLine("Press ENTER to exit");
        Console.ReadLine();
    }
}