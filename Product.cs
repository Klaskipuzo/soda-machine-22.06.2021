using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soda_machine_22._06._2021
{
    class Machine
    {
        public string Name { get; set; }
        /// <summary>
        /// Не придумал, что здесь написать )
        /// </summary>
        public virtual void user()
        {
            Console.WriteLine(" ");
        }
    }

    class Tea : Machine
    {
        public override void user()
        {
            Console.WriteLine("To buy Tea, press button 1.");
        }
    }
    class Coffie : Machine
    {
        public override void user()
        {
            Console.WriteLine("To buy Coffie, press button 2.");
        }
    }
    class Juce : Machine
    {
        public override void user()
        {
            Console.WriteLine("To buy Juce, press button 3.");
        }
    }
    class Soda : Machine
    {
        public override void user()
        {
            Console.WriteLine("To buy Soda, press button 4.");
        }
    }
}
