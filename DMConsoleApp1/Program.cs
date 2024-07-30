namespace DMConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 4;
            double secondNumber = 2;
            double MultiplyResault = firstNumber * secondNumber;
            Console.WriteLine("Multiply Resault:"+MultiplyResault);
            double DivideResault = firstNumber / secondNumber;
            Console.WriteLine("Divide Rseauult:" + DivideResault);
        }
        static double Multiply(double firstNumber,double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        static double Divide(double firstNumber,double secondNumber)
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("ERROR");
                return 0;
            }
            return firstNumber / secondNumber;
        }
    }
}
