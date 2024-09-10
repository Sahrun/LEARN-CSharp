using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_54_Recursion_Section_54_5
{
    internal class Program
    {
        internal const int Rootlevel = 0;
        internal const char Tab = '\t';

        internal static void Main()
        {
            Console.WriteLine("Enter the path of the root directory:");
            var rootDirectorypath = Console.ReadLine();
            Console.WriteLine(
                $"Getting directory tree of '{rootDirectorypath}'"
                );
            PrintDirectoryTree(rootDirectorypath);
            Console.WriteLine("Press 'Enter' to quit..");
            Console.ReadLine();

        }

        internal static void PrintDirectoryTree(string rootDirectoryPath)
        {
            try
            {
                if (!Directory.Exists(rootDirectoryPath))
                {
                    throw new DirectoryNotFoundException(
                        $"Directory '{rootDirectoryPath}'"
                        );
                }

                var rootDirectory = new DirectoryInfo(rootDirectoryPath);

                PrintDirectoryTree(rootDirectory, Rootlevel);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintDirectoryTree(DirectoryInfo directory, int currentLevel)
        {
            var indentation = string.Empty;
            for (var i = Rootlevel; i < currentLevel; i++)
            {
                indentation += Tab;
            }

            Console.WriteLine($"{indentation}-{directory.Name}");
            var nextLevel = currentLevel + 1;

            try
            {
                foreach (var subDirectory in directory.GetDirectories())
                {

                    PrintDirectoryTree(subDirectory, nextLevel);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"{indentation} - {e.Message}");

            }

        }
    }
}
