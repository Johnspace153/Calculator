using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public static class Calculations
    {
        public static double storedValue;
        public static double AddNumbers(this List<double> value)
        {
            double output = 0;
            foreach (double num in value) 
            {
                 output += num;
            }

            return output;
        }

        public static double MinusNumbers(this List<double> value) 
        {
            double output = value[0];
            for (int i = 1; i < value.Count; i++)
            {
                output -= value[i];
            }

            return output;
        }

        public static double TimesNumbers(this List<double> value) 
        {
            double output = 1;
            foreach (double num in value)
            {
                output *= num;
            }

            return output;
        }

        public static double DivideNumbers(this List<double> value)
        {
            double output = value[0];
           
            for (int i = 1; i < value.Count; i++)
            {
                if (value[i] == 0)
                {
                    throw new DivideByZeroException();
                }

                output /= value[i];
            }
            return output;
        }

        public static double ModulusNumbers(this List<double> value)
        {
            double output = value[0];
            
            if (value.Count == 0)
            {
                throw new InvalidOperationException("The list must contain at least one number.");
            }

            for (int i = 1; i < value.Count; i++)
            {
                if (value[i] == 0)
                {
                    throw new DivideByZeroException();
                }

                output %= value[i];
            }

            return output;
        }

        public static double ToThePower(double baseNumber, double exponent)
        {
            if(exponent < 0)
            {
                baseNumber = 1/baseNumber;
                exponent = -exponent;
            }

            double output = 1;
            for (int i = 0; i < exponent; i++)
            {
                output *= baseNumber;
            }
            return output;
        }

    }
}
