using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.GerenciadorDeBonificacao
{
    internal class GerenciadorDeBonificacao
    {
        private double totalBonificacao { get; set; }

        public void Registra (Funcionario funcionario)
        {
            totalBonificacao += funcionario.getBonificacao();
            Console.WriteLine(totalBonificacao);
        }

        public void Registra (Diretor diretor)
        {
            totalBonificacao += diretor.getBonificacao();
            Console.WriteLine(totalBonificacao);
        }
    }
}
