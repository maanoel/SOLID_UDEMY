using System;

namespace SOLID
{
  class ClienteRico
  {
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Endereco { get; private set; }

    private string _sobreNome;

    public string SobreNome
    {
      get => _sobreNome;
      private set => _sobreNome = value;
    }


    public ClienteRico(int id, string nome, string endereco)
    {
      DomainExceptionValidationException.When(id <= 0, "Não pode ser menor que zero.");

      Id = id;
      Nome = nome;
      Endereco = endereco;
    }

    public void Enderecos(params string[] enderecos)
    {

    }

    //Exemplo de argumentos nomeados

    public void AlterarInformacoes(int id, string nome, string endereco)
    {
      Console.WriteLine($"{id}, {nome}, {endereco}");
    }
  }
}
