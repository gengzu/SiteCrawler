using System;
using Microsoft.AspNet.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplication.Run<Crawler.Web.Startup>(args);
        
        Console.WriteLine("Crawler Web site started");        
        Console.WriteLine();        
        Console.WriteLine("Press ENTER to exit");
        Console.ReadLine();
    }
}