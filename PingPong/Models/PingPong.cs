using System.Collections.Generic;
using System;

namespace PingPong
{
  public class PingPongGenerator
  {
    public List<string> PingPong(int range)
    {
      List<string> result = new List<string>();
      for (int i = 1; i <= range; i++)
      {
        result.Add(i.ToString());
      }
      return result;
    }
  }
}
