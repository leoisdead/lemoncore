//MATHHHHHH! idk you can just do 1+1 but this is here plus lerp!!
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
        public static float Lerp(float min, float max, float alpha)
        {
            float result = min + (max - min) * alpha;
            return result;
        }
    }
}
