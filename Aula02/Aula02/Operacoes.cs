using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    class Operacoes
    {
        public void Sacar(ContaBancaria conta)
        {
            Console.WriteLine("Informe o valor a ser sacodo: R$");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            if (conta.Saldo < valor)
            {
                Console.WriteLine("Inpossível sacar o valor desejado!");
                Console.WriteLine("Saldo atual: R$ " + conta.Saldo);
                Console.WriteLine();
            }
            else
            {
                conta.Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine("Saldo atual: R$ " + conta.Saldo);
                Console.WriteLine();
            }

        }

        public void Depositar(ContaBancaria conta)
        {
            Console.WriteLine("Informe o valor a ser depositado: R$");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            conta.Saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!");
            Console.WriteLine("Saldo atual: R$ " + conta.Saldo);
            Console.WriteLine();
        }

        public void Extrato(ContaBancaria conta)
        {
            Console.WriteLine("Nome: " + conta.Nome);
            Console.WriteLine("CPF: " + conta.Cpf);
            Console.WriteLine("Tipo da Conta: " + conta.TipoConta);
            Console.WriteLine("Saldo atual: R$ " + conta.Saldo);
            Console.WriteLine();
        }
    }
}
