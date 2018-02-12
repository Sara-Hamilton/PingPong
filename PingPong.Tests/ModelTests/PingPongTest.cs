using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void PingPong_ReturnsAnArray_Array()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("1,2,3,4,5", testPingPong.PingPong(5));
    }
  }
}
