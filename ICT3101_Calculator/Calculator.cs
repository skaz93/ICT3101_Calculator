using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, double num3, double num4, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            
            FileReader getTheMagic = new FileReader();
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    // Factorial of first input number.
                    result = Factorial(num1);
                    break;
                case "t":
                    // Area of Triangle.
                    result = AreaTriangle(num1, num2);
                    break;
                case "o":
                    // Area of Circle.
                    result = AreaCircle(num1);
                    break;
                case "p":
                    // Permutation.
                    result = Permutation(num1, num2);
                    break;
                case "c":
                    // Combination.
                    result = Combination(num1, num2);
                    break;
                case "x":
                    // Calculate MBTF.
                    result = Mtbf(num1, num2);
                    break;
                case "y":
                    // Calculate Availability.
                    result = Availability(num1, num2);
                    break;
                case "z":
                    // Calculate Current Failure Intensity
                    result = CFI(num1, num2, num3);
                    break;
                case "e":
                    // Calculate Average number of Failure.
                    result = AvgFailure(num1, num2, num3, num4);
                    break;
                case "dd":
                    // Calculate Defect Density.
                    result = DefectDensity(num1, num2);
                    break;
                case "k":
                    // Calculate Defect Density.
                    result = KSSI(num1, num2, num3);
                    break;
                case "g":
                    // Calculate Defect Density.
                    result = GenMagicNum(num1, getTheMagic);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        //public double Add(double num1, double num2)
        //{
        //    return (num1 + num2);
        //}
        //test

        public double Add(double num1, double num2)
        {
            if (( ((num1 % 10) >= 2) | ((num1/10) >= 2) ) | (((num2 % 10) >= 2) | ((num2 / 10) >= 2)))  
            {
                return (num1 + num2);
            }
            string binarynum = num1.ToString() + num2.ToString();

            return (Convert.ToInt32(binarynum,2));
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            if ((num1 == 0) & (num2 == 0))
            {
                return (1);
            }

            if ((num1 == 0) & (num2 > 0))
            {
                return(0);
            }

            return (num1 / num2);
        }
        public double Factorial(double num1)
        {
            int i = 1;
            int result = 1;

            if (num1 < 0)
            {
                throw new ArgumentException("Invalid Input");
            }

            if (num1 == 0)
            {
                return result;
            }

            while (i <= num1)
            {
                result = result * i;
                i++;
            }
            return result;
        }

        public double AreaTriangle(double num1, double num2)
        {
            return (num1 * num2 * 1 / 3);
        }

        public double AreaCircle(double num1)
        {
            return (num1 * num1 * 3.14);
        }

        public double Permutation(double num1, double num2)
        {

            return (Factorial(num1) / Factorial(num1 - num2));
        }

        public double Combination(double num1, double num2)
        {

            return (Factorial(num1) / (Factorial(num2) * Factorial(num1 - num2)));
        }

        public double Mtbf(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException("Invalid Input");
            }
            return (Add(num1, num2));
        }

        public double Availability(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException("Invalid Input");
            }
            double sum = 0;
            sum = Add(num1, num2);
            return (num1/sum);
        }

        public double CFI(double num1, double num2, double num3)
        {
            return (num3 * (1 - (num2/num1)));
        }

        public double AvgFailure(double num1, double num2, double num3, double num4)
        {
            double expNum = 0;
            expNum = Math.Exp(-(num3 / num1) * num4);
            return (Math.Round(num1*(1-expNum),0));
        }

        public double DefectDensity(double num1, double num2)
        {
            return (num1/num2);
        }

        public double KSSI(double num1, double num2, double num3)
        {
            return (num1 + num2 - (num2 * num3 /100));
        }

        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);
            //Dependency------------------------------
            //----------------------------------------
            string[] magicStrings = fileReader.Read(@"C:\Users\Gary\source\repos\ICT3101 Lab\ICT3101_Calculator\MagicNumbers.txt");
/*            string[] magicStrings = fileReader.Read("MagicNumbers.txt");*/
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }


    }
}
