using bytebank.ExercicioExtra;
using bytebank.TipoDeConta;
using bytebank.Titular;
using System;
using System.Collections.Concurrent;
using System.Runtime.Intrinsics.Arm;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente contaDaCarol = new ContaCorrente();
            //contaDaCarol.numero_agencia = 1234;
            //contaDaCarol.titular = "Carolina Aizawa";
            //contaDaCarol.conta = "111222-x";
            //contaDaCarol.saldo = 100.00;

            ////Console.WriteLine($"Saldo da conta da {contaDaCarol.titular}: R$ {String.Format("{0:0.00}", contaDaCarol.saldo)}");

            //contaDaCarol.Deposita(100.00);

            ////Console.WriteLine($"Saldo da conta da {contaDaCarol.titular}: R$ {String.Format("{0:0.00}", contaDaCarol.saldo)}");

            ///*contaDaCarol.SacaValor(300);
            ///Console.WriteLine($"Saldo da conta: R$ {contaDaCarol.saldo}");*/

            //ContaCorrente contaDoMatheus = new ContaCorrente();
            //contaDoMatheus.titular = "Matheus Teixeira";
            //contaDoMatheus.numero_agencia = 1234;
            //contaDoMatheus.saldo = 500.00;
            //contaDoMatheus.conta = "1234-x";

            //Console.WriteLine($"Saldo da conta {contaDoMatheus.titular}: R${String.Format("{0:0.00}", contaDoMatheus.saldo)}");
            //Console.WriteLine(contaDaCarol.TransfereValor(50, contaDoMatheus));
            //Console.WriteLine($"Saldo da conta {contaDoMatheus.titular}: R${String.Format("{0:0.00}",contaDoMatheus.saldo)}");

            //contaDaCarol.ExibirInformacoesDaContaCorrente();
            //contaDoMatheus.ExibirInformacoesDaContaCorrente();

            //Cliente c1 = new Cliente();
            //c1.NomeCompleto = "André Silva";
            //c1.Cpf = "123456789";
            //c1.Profissao = "Analista";

            //c1.exibirDadosDoCliente();


           ContaCorrente c1 = new ContaCorrente("Nome", 12, "1234-x");
            

        }
    }
}
