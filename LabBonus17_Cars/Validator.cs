using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LabBonus17_Cars
{
    class Validator
    {
        public static bool CheckNumberOfCars(string input)
        {
            if (Regex.Match(input, @"^\d+$").Success)
            {
                if (int.Parse(input) >0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;
        }

        public static bool CheckBlankInput(string input)
        {
            if(string.IsNullOrEmpty(input) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckYear(string input)
        {
            if (Regex.Match(input, @"^[1-2]{1}\d{3}$").Success)
            {
                //car must be a realistic model year - 1900 to 2020
                if (int.Parse(input) >= 1900 && int.Parse(input) <= 2020)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;
        }

        public static bool CheckPrice(string input)
        {
            //must have realistic price, minimum in the hundreds
            if(Regex.Match(input, @"^[1-9]{1}[0-9]{2,}$").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
