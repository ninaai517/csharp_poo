using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.TipoDeConta;

namespace bytebank.Titular
{
    public class Cliente
    {
        public string NomeCompleto { get;  private set; }
        public string Cpf { get; private set; }
        public string Profissao { get; private set; }

        public void exibirDadosDoCliente()
        {
            Console.WriteLine("Deseja exibir os dados do cliente ?");
            string perguntaUsuario = Console.ReadLine();
            if (perguntaUsuario == "S")
            {
                Console.WriteLine($"Nome Completo: {NomeCompleto}");
                Console.WriteLine($"CPF: {Cpf}");
                Console.WriteLine($"Profissão: {Profissao}");
            }
        }
    }
}
