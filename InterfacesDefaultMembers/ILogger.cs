namespace SOLID.Interfaces
{
  public interface ILogger
  {
    void Info(string message);

    void Erro(string message)
    {
      System.Console.WriteLine(message);
    }
  }
}
