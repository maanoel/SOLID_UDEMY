namespace SOLID.LSPViolado
{
  class Teste
  {
    public void TesteIspViolado() {
      
      Ave ave = new Ave(); //
      Ave pardal = new Pardal(); // 
      Ave avestruz = new Avestruz(); //
      avestruz.Voar(); // Oxe, mas avestruz não deveria voar..
    }
  }
}
