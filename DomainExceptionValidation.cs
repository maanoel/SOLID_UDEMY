using System;
using System.IO;

namespace SOLID
{
  public class DomainExceptionValidationException : Exception
  {
    public DomainExceptionValidationException(string error) : base(error)
    {

    }

    public static void When(bool hasError, string error)
    {
      if (hasError)
        throw new DomainExceptionValidationException(error);
    }


  }
}
