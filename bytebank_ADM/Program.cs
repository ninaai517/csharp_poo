using bytebank_ADM.Funcionarios;
using bytebank_ADM.GerenciadorDeBonificacao;

Funcionario f1 = new Funcionario();
f1.Nome = "Marcela Diniz";
f1.Cpf = "123456789";
f1.Salario = 2000.00;

Console.WriteLine(f1.getBonificacao());

Diretor d1 = new Diretor();
d1.Nome = "Bianca Moreno";
d1.Cpf = "789456123";
d1.Salario = 15000;

Console.WriteLine(d1.getBonificacao());

GerenciadorDeBonificacao g1 = new GerenciadorDeBonificacao();
g1.Registra(f1);
g1.Registra(d1);
Console.WriteLine();
