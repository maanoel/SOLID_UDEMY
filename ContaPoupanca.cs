namespace SOLID_UDEMY
{
  public class ContaPoupanca : Conta
  {
    public new void Depositar(decimal valor)
    {
      if (Saldo <= 0) return;

      Saldo = valor;
    }
  }
}
