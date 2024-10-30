// See https://aka.ms/new-console-template for more information
using System;

namespace calculadora_plus
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu:\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Resto da Divisão\n6 - Potenciação\n0 - Sair");
            string opcao = Console.ReadLine();
            switch(opcao)
            {
                case "1":
                    Somar();
                    break;
                case "2":
                    Subtrair();
                    break;
                case "3":
                    Multiplicar();
                    break;
                case "4":
                    Dividir();
                    break;
                case "5":
                    Resto_Divisao();
                    break;
                case "6":
                    Potenciacao();
                    break;
                case "0":
                    Console.WriteLine("Obrigado Por Usar a Calculadora_Plus Versão: 1.0");
                    break;
                default:
                    Menu();
                    break;
            }
        }
        public static void Somar()
        {
            double n1, n2;
            Console.Write("Primeiro valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Soma: {n1} + {n2} = {n1 + n2}");
            Console.ReadLine();
            Menu();
        }
        public static void Subtrair()
        {
            Double n1, n2;
            Console.Write("Primeiro valor: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            n2 = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Subtração: {n1} - {n2} = {n1 - n2}");
            Console.ReadLine();
            Menu();
        }
        public static void Multiplicar()
        {
            double n1, n2;
            Console.Write("Primeiro valor: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            n2 = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplicação: {n1} x {n2} = {n1*n2}");
            Console.ReadLine();
            Menu();
        }
        public static void Dividir()
        {
            double n1, n2;
            Console.Write("Dividendo: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.Write("Divisor: ");
            n2 = Double.Parse(Console.ReadLine());

            if (n2 != 0)
                Console.WriteLine($"Divisão: {n1} / {n2} = {n1/n2}");
            else
                Console.WriteLine("Divisões por zero são indefinidas");
            Console.ReadLine();
            Menu();
        }
        public static void Resto_Divisao()
        {
            double n1, n2;
            Console.Write("Dividendo: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.Write("Divisor: ");
            n2 = Double.Parse(Console.ReadLine());

            if (n2 != 0)
                Console.WriteLine($"Resto da Divisão: {n1} % {n2} = {n1%n2}");
            else
                Console.WriteLine("Divisões por zero são indefinidas");
            Console.ReadLine();
            Menu();
        }
        public static void Potenciacao()
        {
            double n1, n2;
            Console.Write("Base: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.Write("Expoente: ");
            n2 = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Potenciação: {n1} ^ {n2} = {Math.Pow(n1, n2)}");
            Console.ReadLine();
            Menu();
        }
    }
}