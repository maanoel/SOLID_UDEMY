namespace SOLID_UDEMY
{
  public static class StringExtensions
  {
    public static string PrimeiraLetraCaixaAlta(this string palavra)
    {
      char[] letras = palavra.ToCharArray();
      letras[0] = char.ToUpper(letras[0]);

      return new string(letras);
    }

    public static string PrimeiraLetraMinuscula(this string palavra)
    {
      char[] letras = palavra.ToCharArray();
      letras[0] = char.ToLower(letras[0]);

      return new string(letras);
    }
  }
}
