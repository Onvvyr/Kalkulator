using System;

namespace Calculator
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            throw new NotImplementedException();
            return a + b;
        }
        public static int Substract(int a, int b)
        {
            return a - b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Power(int a, int b)
        {
            int wynik = 1;
            for (int i = b; i > 0; i--)
            {
                wynik = wynik * a;
            }
            return wynik;
        }
    }
}
