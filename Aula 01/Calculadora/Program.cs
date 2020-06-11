using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var saida = 1;

            while (saida != 0)
            {
                decimal valor1 = 0;
                decimal valor2 = 0;
                var operador = '+';

                Console.WriteLine("Informe o primeiro valor:");
                valor1 = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("Informe o operador desejado: (+,-,*,/)");
                operador = Char.Parse(Console.ReadLine());

                Console.WriteLine("Informe o segundo valor:");
                valor2 = Decimal.Parse(Console.ReadLine());
                switch (operador)
                {
                    case '+':
                        Console.WriteLine("Valor da soma de " + valor1 + " + " + valor2 + " = " + Somar(valor1, valor2));
                        break;
                    case '-':
                        Console.WriteLine("Valor da Subtração de " + valor1 + " - " + valor2 + " = " + Subtrair(valor1, valor2));
                        break;
                    case '*':
                        Console.WriteLine("Valor da Multiplicação de " + valor1 + " * " + valor2 + " = " + Multiplicar(valor1, valor2));
                        break;
                    case '/':
                        if (valor2 == 0)
                        {
                            Console.WriteLine("Impossível dividir por 0");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Valor da Divisão de " + valor1 + " / " + valor2 + " = " + Dividir(valor1, valor2));
                            break;
                        }
                    default:
                        Console.WriteLine("Operador inválido");
                        break;
                }
                Console.WriteLine("Informe 1 para realizar nova operação ou 0 para sair:");
                saida = int.Parse(Console.ReadLine());
            }
            
        }

        public static decimal Somar(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 + valor2;
            return resultado;
        }

        public static decimal Subtrair(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 - valor2;
            return resultado;
        }

        public static decimal Multiplicar(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 * valor2;
            return resultado;
        }

        public static decimal Dividir(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 / valor2;
            return resultado;
        }
    }
}
