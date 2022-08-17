namespace SOLID_UDEMY
{
  partial class Program
  {
    class Pessoa {
      //field 
      public string Nome;
      public string Genero;

      public void Identificar() {
        System.Console.WriteLine($"Olá {Nome} do sexo {Genero}");
      }
    }
  }
}
