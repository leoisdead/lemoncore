using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemonCore.Libs
{
    public class math
    {
        public static int Sign(float num)
        {
            return Math.Sign(num);
        }
        public static double round(float num)
        {
            return Math.Round(num);
        }
        public static decimal Min(decimal num1, decimal num2)
        {
            return Math.Min(num1, num2);
        }
        public static decimal Max(decimal num1, decimal num2)
        {
            return Math.Max(num1, num2);
        }
        public static double Cos(double num)
        {
            return Math.Cos(num);
        }
        public static float Divide(float num1, float num2)
        {
            return num1 / num2;
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
            MessageBox.Show(result.ToString(), "killerx9898");
            return result;
        }
    }
}
