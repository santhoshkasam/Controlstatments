using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlstatments
{
  class Program
  {
    static void Main(string[] args)
    {
      #region if
      int n1 = 10, n2 = 11;
      if (n1 > n2)
        Console.WriteLine("n1 is greter");
      else if (n2 > n1)
        Console.WriteLine("n2 is greater");
      else
      {

      }
      #endregion

      #region switch
      //case str is not valid only constant is exprected.
      string str;
      Console.WriteLine("Enter some alphabet now: ");
      str = Console.ReadLine();
      switch (str)
      {
        case "a":
          Console.WriteLine("Acsii no is 97");
          break;
        case "b":
        case "A":
          {
            Console.WriteLine("Acsii no is b-98 & A-65");
            break;
          }
        default:
          Console.WriteLine("Don't know the Ascii please enter a or A");
          break;
      }
      #endregion

      #region while

      int n = 0;
      while (true)
      {
        n++;
        if (n == 3)
          continue;
        if (n == 8)
          break;
        Console.WriteLine(n);
      }

      #endregion

      #region for
      string[] strAr = { "one,two,three,four,five" };
      for (int i = 0; i < strAr.Length; i++)
      {
        Console.WriteLine(strAr[i]);
      }

      foreach (var variable in strAr)
      {
        Console.WriteLine(variable);
      }

      #endregion

      #region Program

      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          if (i == j)
            continue;
          Console.WriteLine(i + " " + j);
        }
      }

      #endregion
    }
  }
}
