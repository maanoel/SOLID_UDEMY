using System;

namespace SOLID_UDEMY
{
  class ClienteRico
  {
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Endereco { get; private set; }


    public ClienteRico(int id, string nome, string endereco)
    {
      DomainExceptionValidationException.When(id <= 0, "Não pode ser menor que zero.");

      Id = id;
      Nome = nome;
      Endereco = endereco;
    }
  }
}
