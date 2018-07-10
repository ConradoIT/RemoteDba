using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace RemoteDba.Terminal.Configuration
{
    public static class Manager
    {
        private static IConfiguration _configuration => LoadConfiguration();

        private static IConfigurationRoot LoadConfiguration()
        {
            return new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                              .AddJsonFile("appsetings.json").Build();
        }

        public static string ConnectionString()
        {
            return _configuration["stringConnetion"];
        }
    }
}
