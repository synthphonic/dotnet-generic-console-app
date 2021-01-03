using System;

namespace NET5GenericConsole.App
{
    public class AppHost : IAppHost
    {
        public void Run()
        {
            Console.WriteLine("I am .NET 5 Generic host console app");
        }
    }
}