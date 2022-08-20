namespace SOLID
{
  class Circulo : Forma
  {
    public override void Desenhar()
    {
      System.Console.WriteLine("Desenha um circulo");
    }

    public void PintarCirculo()
    {
      System.Console.WriteLine("Pinta um circulo");
    }
  }
}
