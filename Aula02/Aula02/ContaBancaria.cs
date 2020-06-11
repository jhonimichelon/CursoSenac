using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    public class ContaBancaria
    {
        public string Nome;
        public decimal Saldo;
        public string Cpf;
        public string TipoConta;
        public int Numero;
        public int Agencia;

        public void CriarConta(List<ContaBancaria> listaContas)
        {
            ContaBancaria novaConta = new ContaBancaria();

            Console.WriteLine("Informe os dados da conta.");
            Console.WriteLine("Informe o nome do títular da conta: ");
            novaConta.Nome = Console.ReadLine();
            Console.WriteLine("Informe o cpf do títular da conta: (Somente números)");
            novaConta.Cpf = Console.ReadLine();
            Console.WriteLine("Informe o tipo de conta: (Corrente, Poupança)");
            novaConta.TipoConta = Console.ReadLine();
            novaConta.Saldo = 0;
            novaConta.Numero = listaContas.Count+1;
            novaConta.Agencia = 100;

            listaContas.Add(novaConta);
            Console.WriteLine("Conta criada com sucesso! Número da conta: " + novaConta.Numero);
        }

        public ContaBancaria BuscarConta(List<ContaBancaria> listaContas)
        {
            Console.WriteLine("Informe o número da conta: ");
            var numeroConta = Convert.ToInt32(Console.ReadLine());

            var encontrou = listaContas.Find(x => x.Numero == numeroConta);
            
            if(encontrou == null)
            {
                Console.WriteLine("Conta não encontrada!");
                return encontrou;
            }
            else
            {
                return encontrou;
            }
        }
    }
}
