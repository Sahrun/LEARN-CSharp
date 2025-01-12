using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_63_Reflection
{
    public class Section_63_11
    {
        public Section_63_11()
        {
            // Get info class from another class
            string typeName = "Chapter_63_Reflection.Section_63_5";
            var type = typeof(Section_63_9).Assembly.GetType(typeName);

            Console.WriteLine(type);

            // search with loop

            Type t = null;
            foreach (Assembly ass in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (ass.FullName.StartsWith("System."))
                    continue;

                t = ass.GetType(typeName);
                if (t != null)
                    break;
            }

            Console.WriteLine(t);

            // ambil info clss menggunakan Fully-Qualified
            string fullyQualifiedName = "Chapter_63_Reflection.Section_63_4,Chapter 63 Reflection";
            t = Type.GetType(fullyQualifiedName);

            Console.WriteLine(t);

            // bisa juga membaca asembly di luar prject dengan membaca path

            // Lokasi Assembly eksternal
            string assemblyPath = Path.Combine(Directory.GetCurrentDirectory(), "HelloPlugin.dll");

            // Memuat Assembly
            Assembly externalAssembly = Assembly.LoadFrom(assemblyPath);

            // Mengambil informasi Assembly
            Console.WriteLine($"Assembly Name: {externalAssembly.FullName}");
        }
    }
}
