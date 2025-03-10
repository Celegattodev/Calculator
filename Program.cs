using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine(" 1 - Soma");
            Console.WriteLine(" 2 - Subtração");
            Console.WriteLine(" 3 - Multiplicação");
            Console.WriteLine(" 4 - Divisão");
            Console.WriteLine(" 5 - Sair");

            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Somar(); break;
                case 2: Subtrair(); break;
                case 3: Multiplicar(); break;
                case 4: Dividir(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Somar()
        {
            Console.Clear();
            Console.WriteLine("Insira o primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"O resultado da soma é {v1 + v2}");
            Menu();
        }

        static void Subtrair()
        {
            Console.Clear();
            Console.WriteLine("Insira o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            double v2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da subtração é {v1 - v2}");
            Menu();
        }

        static void Multiplicar()
        {
            Console.Clear();
            Console.WriteLine("Insira o primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"O resultado da multiplicação é {v1 * v2}");
            Menu();
        }
        static void Dividir()
        {
            Console.Clear();
            Console.WriteLine("Insira o primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"O resultado da divisão é {v1 / v2}");
            Menu();
        }
    }
}