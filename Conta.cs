namespace SOLID_UDEMY
{
  public class Conta
  {
    public decimal Saldo { get; protected set; }

    public void Depositar(decimal valor)
    {
      if (valor <= 0) return;

      Saldo += valor;
    }
  }
}
