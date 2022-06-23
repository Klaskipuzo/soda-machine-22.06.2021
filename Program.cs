using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
//
namespace soda_machine_22._06._2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MachineAuto();
        }
        /// <summary>
        /// Метод вызова начала программы
        /// </summary>
        public static void MachineAuto()
        {
            // Не стал выносить свитч в отдельный метод, хочу попробовать выносить в другом решении данной задачи,
            // когда освою epam

            Machine[] machines = new Machine[4];

            Tea tea = new Tea();
            tea.Name = "Lipton";

            Coffie coffie = new Coffie();
            coffie.Name = "Nescafe";

            Juce juce = new Juce();
            juce.Name = "May_family";

            Soda soda = new Soda();
            soda.Name = "Coca_cola";

            machines[0] = tea;
            machines[1] = coffie;
            machines[2] = juce;
            machines[3] = soda;

            for (int i = 0; i < machines.Length; i++)
            {
                Console.WriteLine("The machine has : " + machines[i].Name);
                machines[i].user();
                
            }
            
            int buttonB = int.Parse(Console.ReadLine());
            switch(buttonB)
            {
                case 1:
                    Console.WriteLine("From you 50 rubles and get" + " " + tea.Name);
                    break;
                case 2:
                    Console.WriteLine("From you 100 rubles and get" + " " + coffie.Name);
                    break;
                case 3:
                    Console.WriteLine("From you 60 rubles and get" + " " + juce.Name);
                    break;
                case 4:
                    Console.WriteLine("From you 80 rubles and get" + " " + soda.Name);
                    break;

            }

        }

        
    }

}
