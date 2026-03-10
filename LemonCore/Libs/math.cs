using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonCore.Libs
{
    public class math
    {
        public static float Divide(float num1, float num2)
        {        
            return num1 / num2;
        }
        public static float Multiply(float num1, float num2)
        { 
            return num1 * num2;
        }
        public static float Add(float num1, float num2)
        {       
            return num1 + num2;
        }
        public static float Subtract(float num1, float num2)
        {
            return num1 + num2;
        }
        public static float lerp(float min, float max, float alpha)
        {
            float result = min + (max - min) * alpha;
            return result;
        }
    }
}
