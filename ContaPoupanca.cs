namespace SOLID
{
  public class ContaPoupanca : Conta
  {
    public new void Depositar(decimal valor)
    {
      if (Saldo <= 0) return;

      Saldo = valor;
    }

    public override void Sacar(decimal valor)
    {
      if (valor >= 1000)
      {
        System.Console.WriteLine("Só é possível sacar com a atendente.");
        return;
      }

      base.Sacar(valor);
    }
  }
}
