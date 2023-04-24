using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.TipoDeConta
{
    public class ContaCorrente
    {
        public static int NumeroDeContasCriadas { get; private set; }
        private int NumeroAgencia { get; set; }
        private Cliente Titular { get; set; }
        private string Conta { get; set; }
        private double Saldo;

        public ContaCorrente(Cliente titular, int numeroAgencia, 
             string conta)
        {
            Titular = titular;
            NumeroAgencia = numeroAgencia;
            Conta = conta;
            NumeroDeContasCriadas++;
        }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public void SacaValor(double valor)
        {
            if (Saldo != null && Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque!");
            }

        }

        public bool TransfereValor(double valor, ContaCorrente contaDestino)
        {
            if (Saldo < valor || contaDestino.Conta == null)
            {
                Console.WriteLine("Saldo insuficiente e/ou conta = null!");
                return false;
            }
            else
            {
                SacaValor(valor);
                contaDestino.Deposita(valor);
                Console.WriteLine("Transferência realizada com sucesso!");
                Console.WriteLine($"Saldo atual: R$ {contaDestino.Saldo}");
                return true;
            }
        }

        public void ExibirInformacoesDaContaCorrente()
        {
            Console.WriteLine($"Deseja exibir as informações da sua conta {Titular} ?");
            string perguntaUsuario = Console.ReadLine();
            if (perguntaUsuario == "Sim" || perguntaUsuario == "sim" || perguntaUsuario == "SIM")
            {
                Console.WriteLine($"Número da agência: {NumeroAgencia}");
                Console.WriteLine($"Número da conta: {Conta}");
                Console.WriteLine($"Titular da conta: {Titular}");
                Console.WriteLine($"Saldo da conta: R$  {string.Format("{0:0.00}", Saldo)}");
            }
            else
            {
                Console.WriteLine("Desconectando!");
            }

        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
               this.Saldo = valor;             
            }
        }

        public void GetSaldo()
        {
            Console.WriteLine(this.Saldo);
        }
    }
}
