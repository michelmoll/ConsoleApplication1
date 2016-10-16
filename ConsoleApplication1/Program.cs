using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature calculator");
            Console.WriteLine("Please enter the numer before the unit you want to enter: \n 1. Celsius \n 2. Fahrenheit \n 3. Reaumur \n 4. Kelvin");
            int input = Console.Read();

            Console.WriteLine("Bitte geben Sie den Wert ein der umgerechnet werden soll: ");
            string inputT = Console.ReadLine();
            double T = 0;
            T = Convert.ToDouble(inputT);
            double K = 0;
            switch (input)
            {
                case 1: 
                    K = T -273.15;
                    break;

                case 2:
                    K = (T + 459.67)/1.8;
                    break;

                case 3:
                    K = 1.25 * T + 273.15;
                    break;

                case 4:
                    K = T;
                    break;
            }
            Console.WriteLine(string.Format("Here is your are the Calculatet other units: \n 1. Celsius = {0} \n 2. Fahrenheit = {1} \n 3. Reaumur = {2} \n 4. Kelvin = {3}",T + 273.15, (T*1.8-459.67),((T-273.25)/1.25)),T);

            Console.ReadLine();
        }
    }
}
