using System;

namespace SOLID
{
  partial class Program
  {
    static void Main(string[] args)
    {
      Pessoa pessoa = new Pessoa();
      pessoa.Nome = "Rafa";
      pessoa.Genero = "feminino";
      //pessoa.Nome.PrimeiraLetraCaixaAlta();
      pessoa.Nome = pessoa.Nome.PrimeiraLetraMinuscula();

      pessoa.Identificar();

      Console.WriteLine(pessoa.Nome);

      ClienteRico clienteRico = new ClienteRico(5, "vitor", "Pituba");
      clienteRico.Enderecos("Pituba", "São caetano", "Salvador Bahia");
      clienteRico.AlterarInformacoes(id: 1, nome: "Vitor", endereco: "Salvador");
    }
  }
}
