using System;
using System.IO;
using HelloWorld.Common;
using Microsoft.Extensions.Configuration;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .AddEnvironmentVariables();

            IConfigurationRoot configuration = builder.Build();

            var settings = new AppSettings();
            configuration.Bind(settings);

            Console.WriteLine($"My application URL '{settings.BaseUrl}'");

            Console.WriteLine(ApiHelper.CallApi_Hello(settings.BaseUrl));

            Console.ReadLine();
        }



    }

    public class AppSettings
    {
        public string BaseUrl { get; set; }
    }
}
