using System;
using System.Collections.Generic;

namespace Aula02
{
    class Program
    {
        public static void Main(string[] args)
        {
            var operacao = "";
            var inicio = "";
            var contaBancaria = new ContaBancaria();
            var listaContas = new List<ContaBancaria>();

            while (inicio != "sair")
            {
                Console.WriteLine("Digite a operação desejada: ");
                Console.WriteLine("c - criar conta | b - buscar conta | sair - para sair");
                inicio = Console.ReadLine().ToLower();
                switch (inicio)
                {
                    case "c":
                        contaBancaria.CriarConta(listaContas);
                        break;
                    case "b":
                        var conta = contaBancaria.BuscarConta(listaContas);
                        var operacoes = new Operacoes();
                        Console.WriteLine("Nome: " + conta.Nome);
                        Console.WriteLine("Informe a operação desejada:");
                        Console.WriteLine("s - sacar | d - depositar | e - extrato | sair - para sair");
                        operacao = Console.ReadLine().ToLower();
                        while (operacao != "sair")
                        {
                            switch (operacao)
                            {
                                case "s":
                                    operacoes.Sacar(conta);
                                    break;
                                case "d":
                                    operacoes.Depositar(conta);
                                    break;
                                case "e":
                                    operacoes.Extrato(conta);
                                    break;
                            }
                            Console.WriteLine("s - sacar | d - depositar | e - extrato | sair - para sair");
                            operacao = Console.ReadLine().ToLower();
                        }
                        break;
                }
            }
        }
    }
}
