using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopCalculator
{
    public class Arithmetics
    {
        public int Calculate(int num1, int num2, string action)
        {
            int result= 0; //grazins 0 jei nei vienas if nebus tenkinamas//
            switch (action)
            {
                case "+":
                    result = num2 + num1;
                    break;
                case "-":
                    result = num2 - num1;
                    break;
                case "x":
                    result = num2 * num1;
                    break;
                case "/":
                    {                    {
                        result = num2 / num1;
                    }

                    break;

            }
            return result;
        }
    }
}
