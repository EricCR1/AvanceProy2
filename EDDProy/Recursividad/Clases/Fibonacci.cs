using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EDDemo.Recursividad.Clases
{
    class Fibonacci
    {
        
        // Método recursivo para calcular Fibonacci
        public static int CalcularFibonacci(int n)
        {
            if (n <= 0) return 0; // Caso base: Fibonacci(0) = 0
            if (n == 1) return 1; // Caso base: Fibonacci(1) = 1

            // Llamadas recursivas
            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }
    }
}
