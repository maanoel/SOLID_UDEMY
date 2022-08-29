namespace SOLID.Interfaces
{
  public class ConsoleLogger : ILogger
  {
    public void Info(string message)
    {
      System.Console.WriteLine(message);
    }
  }
}
