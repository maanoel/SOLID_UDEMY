namespace SOLID
{
  partial class Program
  {
    class Pessoa
    {
      //public string nome;

      //public string Nome
      //{
      //  get { return nome; }
      //  set { nome = value; }
      //}

      public string Genero;
      private int _idade;

      public int Idade
      {
        get { return _idade; }
        set { if (value > 18) { System.Console.WriteLine("Maluco é maior de idade"); _idade = value; } }
      }

      public string Nome { get; set; }

      public void Identificar()
      {
        Idade = 10;

        System.Console.WriteLine($"Olá {Nome} do sexo {Genero} {Idade}");
      }
    }
  }
}
