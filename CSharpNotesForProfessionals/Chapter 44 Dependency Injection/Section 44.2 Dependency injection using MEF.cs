
using System;
using System.Collections.Generic;
using System.Composition;
using System.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Chapter_44_Dependency_Injection_Section_44_2
{
    public interface ILogger
    {
        void Log(string message);
    }

    // Implementasi ConsoleLogger
    [Export(typeof(ILogger))]
    [ExportMetadata("Name", "Console")]
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    // Implementasi FileLogger
    [Export(typeof(ILogger))]
    [ExportMetadata("Name", "File")]
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // Write the message to file
        }
    }

    // Definisikan User
    public class User
    {
        private readonly ILogger _logger;

        public User(ILogger logger)
        {
            _logger = logger;
        }

        public void LogUser(string message)
        {
            _logger.Log(message);
        }
    }

    // Definisikan kontrak metadata
    public interface ILoggerMetaData
    {
        string Name { get; }
    }

    // Program utama
    internal class Program
    {
        [ImportMany]
        public IEnumerable<Lazy<ILogger, ILoggerMetaData>> Loggers { get; set; }

        private static void Main()
        {
            var program = new Program();
            program.ComposeLoggers();

            var loggerNameAndLoggerMapping = program.Loggers.First(n => n.Metadata.Name.ToUpper() == "CONSOLE"); ILogger logger = loggerNameAndLoggerMapping.Value;

            var user = new User(logger);
            user.LogUser("user name");
        }

        private void ComposeLoggers()
        {
            // Membuat konfigurasi kontainer
            var configuration = new ContainerConfiguration()
                .WithAssembly(Assembly.GetExecutingAssembly());

            // Menambahkan direktori jika diperlukan
            string loggersDllDirectory = Path.Combine(Utilities.GetApplicationDirectory(), "Loggers");
            if (!Directory.Exists(loggersDllDirectory))
            {
                Directory.CreateDirectory(loggersDllDirectory);
            }

            // Membuat kontainer dan memuaskan impor
            using (var container = configuration.CreateContainer())
            {
                try
                {
                    container.SatisfyImports(this);
                }
                catch (CompositionFailedException compositionException)
                {
                    throw new CompositionFailedException(compositionException.Message);
                }
            }
        }
    }

    // Utilities class untuk mendapatkan direktori aplikasi
    public static class Utilities
    {
        public static string GetApplicationDirectory()
        {
            return AppContext.BaseDirectory;
        }
    }

}
