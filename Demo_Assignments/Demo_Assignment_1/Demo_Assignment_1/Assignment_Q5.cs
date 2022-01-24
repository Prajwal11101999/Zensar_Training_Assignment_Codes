using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_1
{
    class Assignment_Q5
    {
        public float Convert1(float temp)
        {
            float tempinC;
            tempinC = ((temp - 32) * 0.5556f);
            return tempinC;
        }

        public float Convert2(float temp2)
        {
            float tempinF;
            tempinF = ((temp2 * 1.8f) + 32);
            return tempinF;
        }

        static void Main(string[] args)
        {
            float TempinF;
            float TempinC;
            Console.WriteLine("Enter the Temprature in Fahrenheit : ");
            TempinF = float.Parse(Console.ReadLine());
            Assignment_Q5 assign = new Assignment_Q5();
            TempinC = assign.Convert1(TempinF);
            Console.WriteLine("The Converted Temrature from Fahrenheit : {0} Fahrenheit, to Celsius is :{1} Celsius",TempinF,TempinC);
            Console.WriteLine("Enter the Temprature in Celsius : ");
            TempinC = float.Parse(Console.ReadLine());
            Assignment_Q5 assign1 = new Assignment_Q5();
            TempinF = assign1.Convert2(TempinC);
            Console.WriteLine("The Converted Temrature from Celsius : {0} Celsius, to Fahrenheit is :{1} Fahrenheits", TempinC, TempinF);
            // Console.WriteLine("Hello.");
        }
    }
}
