using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_44_Dependency_Injection_Section_44_1
{
    public class AnimalController
    {
        private SantaAndHisReindeer _SantaAndHisReindeer = new SantaAndHisReindeer();

        public AnimalController()
        {
            Console.WriteLine();
        }
    }

    internal interface ISantaAndHisReindeer
    {
        void DoSomething();
    }

    internal class SantaAndHisReindeer : ISantaAndHisReindeer
    {
        public void DoSomething()
        {
            Console.WriteLine("DoSomething");
        }
    }

    internal class NewSantaAndHisReindeer : ISantaAndHisReindeer
    {
        public void DoSomething()
        {
            Console.WriteLine("DoSomething v.2");
        }
    }

    internal class AnimalV2Controller
    {
        private readonly ISantaAndHisReindeer _santaAndHisReindeer;
        internal AnimalV2Controller(ISantaAndHisReindeer santaAndHisReindeer)
        {
            _santaAndHisReindeer = santaAndHisReindeer;
        }

        public void DoWork()
        {
            _santaAndHisReindeer.DoSomething();
        }
    }

}
