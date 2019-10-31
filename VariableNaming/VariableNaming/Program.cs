using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 15;
            int resultAdd;
            int resultMinus;
            int resultDivide;
            int resultMultiply;
            int resultModulus;

            resultAdd = num1 + num2;
            resultMinus = num1 - num2;
            resultDivide = num1 / num2;
            resultMultiply = num1 * num2;
            resultModulus = num1 % num2;

            Console.WriteLine("The result of ${0} + ${1} = ${2} ", num1, num2, resultAdd);
            Console.WriteLine("The result of ${0} - ${1} = ${2} ", num1, num2, resultMinus);
            Console.WriteLine("The result of ${0} / ${1} = ${2} ", num1, num2, resultDivide);
            Console.WriteLine("The result of ${0} * ${1} = ${2} ", num1, num2, resultMultiply);
            Console.WriteLine("The result of ${0} % ${1} = ${2} ", num1, num2, resultModulus);

        }
    }
}
