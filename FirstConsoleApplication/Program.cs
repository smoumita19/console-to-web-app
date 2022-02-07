using System;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Will print in the console
            CreateHostBuilder(agrs).Build().Run();
        }
        
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults( webBuilder =>  
            {
                webBuilder.useStartup<Startup>();
            });
        }
    }
}
