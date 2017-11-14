using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

  public class SrcMac
  {
    public byte[] srcMac = new byte[6];
  
    public void SetSrcMac (byte[] value)
    {

      srcMac = value;
    }

    public string Hex2String (byte[] value)
    {
      string s = String.Concat(value.Select(b => b.ToString("X2")));
      return s;
    }

  }

  
  class Program
  {
    static void Main(string[] args)
    {
      byte[] value1 = new byte[]{0xAA, 0xBB, 0xCC, 0xDD, 0xEE, 0xFF};
      byte[] value2 = new byte[]{0xAA, 0xBB, 0xCC, 0xDD, 0xEE, 0xFF};
      byte[] value3 = new byte[6];
      byte[] value4 = new byte[6];
      
      var s = new SrcMac();
      
      //Console.WriteLine(SrcMac.SetSrcMac(newa));
      Console.WriteLine(value1);
      Console.WriteLine("value 1: " +s.Hex2String(value1));
      value3 = value1;
      Console.WriteLine("value 3: " + s.Hex2String(value3));

      if (value1 != value2)
      {
        Console.WriteLine("if val 1 and val 2 == equal: " + s.Hex2String(value1) + " " + s.Hex2String(value2));
      }

      if (value1.SequenceEqual(value2))
      {
        Console.WriteLine("if val 1 and val 2 if equal: " + s.Hex2String(value1) + " " + s.Hex2String(value2));
      }

      if (value1.SequenceEqual(value3))
      {
        Console.WriteLine("if val 1 and val 2 if equal: " + s.Hex2String(value1) + " " + s.Hex2String(value3));
      }

      
      if (value1.SequenceEqual(value3))
      {
        Console.WriteLine("if val 1 and val 2 if equal: " + s.Hex2String(value1) + " " + s.Hex2String(value3));
      }

      s.SetSrcMac(value1);

      if (value1.SequenceEqual(s.srcMac))
      {
        Console.WriteLine("if val 1 and s if equal: " + s.Hex2String(value1) + " " + s.Hex2String(s.srcMac));
      }



      Console.ReadLine();
    }
  }
}
