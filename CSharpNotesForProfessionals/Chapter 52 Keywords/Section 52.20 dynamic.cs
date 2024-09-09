using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_20
{
    internal class Section_52_20
    {
        public Section_52_20()
        {
            dynamic info = new ExpandoObject();

            info.Id = 123;
            info.Another = 456;

            Console.WriteLine(info.Id);

            Console.WriteLine(info.Another);

            //Console.WriteLine(info.DoesntExist);

            var person = "Person";
            Console.WriteLine(person.SayHello());
            dynamic managaer = "Manager";
            //Console.WriteLine(managaer.SayHello());
            try
            {
                string json = @"{x:10,y:""ho""}";
                dynamic? deserializerJson = JsonConvert.DeserializeObject(json);
                int x = deserializerJson.x;
                string y = deserializerJson.y;
                var hellomanager = StringExtensions.SayHello(managaer);
                Console.WriteLine(hellomanager);
            }
            catch (RuntimeBinderException ex)
            {

            }
        }
    }


    static class StringExtensions
    {
        public static string SayHello(this string s) => $"Hello {s}!";
    }



}
