using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_58_Inheritance_Section_58_9
{
    public abstract class Car
    {
        public void HonkHorn()
        {
            // Implementation of horn being honked
        }
        // virtual methods CAN be overridden in derived classes
        public virtual void ChangeGear()
        {
            // Implementation of gears being changed
        }
        // abstract methods MUST be overridden in derived classes
        public abstract void Accelerate();
    }
    public class Mustang : Car
    {
        // Before any code is added to the Mustang class, it already contains
        // implementations of HonkHorn and ChangeGear.
        // In order to compile, it must be given an implementation of Accelerate,
        // this is done using the override keyword
        public override void Accelerate()
        {
            // Implementation of Mustang accelerating
        }
        // If the Mustang changes gears differently to the implementation in Car
        // this can be overridden using the same override keyword as above
        public override void ChangeGear()
        {
            // Implementation of Mustang changing gears
        }
    }
}
