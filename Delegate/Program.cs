using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegate
{
    internal class MathOperations
    {
        public delegate int MathOperationDelegate(int a, int b);

        public int PerformOperation(MathOperationDelegate operation, int a, int b)
        {
            return operation(a, b);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static void Main()
        {
            MathOperations mathOperations = new MathOperations();

            // Utilisation du délégué pour additionner deux entiers
            MathOperationDelegate addDelegate = new MathOperationDelegate(Add);
           // addDelegate += Multiply;
          // int resu= addDelegate.Invoke(4, 5);
            Console.WriteLine($"Addition result: {resu}");
            int resultAdd = mathOperations.PerformOperation(addDelegate, 5, 3);
            
            Console.WriteLine($"Addition result: {resultAdd}");

            // Utilisation du délégué pour multiplier deux entiers
            MathOperationDelegate multiplyDelegate = new MathOperationDelegate(Multiply);
            int resultMultiply = mathOperations.PerformOperation(multiplyDelegate, 6, 2);
            Console.WriteLine($"Multiplication result: {resultMultiply}");
        }
    }
}
