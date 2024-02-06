using System;
using System.Transactions;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculadora");
                Console.WriteLine("------------------");

                Console.WriteLine("Coloque o primeiro número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Coloque o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("\t+ : Adição");
                Console.WriteLine("\t- : Subtração");
                Console.WriteLine("\t* : Multiplicação");
                Console.WriteLine("\t/ : Divisão");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"O seu resultado é: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"O seu resultado é: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"O seu resultado é: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"O seu resultado é: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Isso não é uma opção válida!");
                        break;
                }
                Console.WriteLine("Gostaria de continuar? (S = sim, N = Não): ");
            } while (Console.ReadLine().ToUpper() == "S");

            Console.WriteLine("Tchau");
            Console.ReadKey();
        }
    }



}