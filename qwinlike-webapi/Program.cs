using System;
using Microsoft.Owin.Hosting;

namespace qwinlike_webapi
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:9000"))
            {
                Console.WriteLine("Нажми интер, а?");
                Console.ReadLine();
            }
        }
    }
}