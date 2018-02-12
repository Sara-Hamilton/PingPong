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
        if (i % 3 == 0 && i % 5 == 0)
        {
          string pingPong = "ping-pong";
          result.Add(pingPong);
        }
        else if (i % 3 == 0)
        {
          string ping = "ping";
          result.Add(ping);
        }
        else if (i % 5 == 0)
        {
          string pong = "pong";
          result.Add(pong);
        }
        else
        {
          result.Add(i.ToString());
        }
      }
      return result;
    }
  }
}
