using CodewarsTasks;
using System.Text;

namespace CodewarsTasksMSTests
{
    [TestClass]
    public class RGBToHexConversionKataTests
    {

        [TestMethod]
        public void RgbMethodTest()
        {
            Assert.AreEqual("FFFFFF", RGBToHexConversionKata.Rgb(255, 255, 255));
            Assert.AreEqual("FFFFFF", RGBToHexConversionKata.Rgb(255, 255, 300));
            Assert.AreEqual("000000", RGBToHexConversionKata.Rgb(0, 0, 0));
            Assert.AreEqual("9400D3", RGBToHexConversionKata.Rgb(148, 0, 211));
            Assert.AreEqual("9400D3", RGBToHexConversionKata.Rgb(148, -20, 211), "Handle negative numbers.");
            Assert.AreEqual("90C3D4", RGBToHexConversionKata.Rgb(144, 195, 212));
            Assert.AreEqual("D4350C", RGBToHexConversionKata.Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }

        [TestMethod]
        public void RgbMethodRandomTest()
        {
            Random rnd = new Random();

            StringBuilder stringBuilder = new StringBuilder();
            
            for (int i = 0; i < 100; i++)
            {
                int r = rnd.Next(255);
                int g = rnd.Next(255);
                int b = rnd.Next(255);

                stringBuilder.Append(r.ToString("X2"));
                stringBuilder.Append(g.ToString("X2"));
                stringBuilder.Append(b.ToString("X2"));

                Console.WriteLine($"Testing for {r},{g},{b}");
                Assert.AreEqual(stringBuilder.ToString(), RGBToHexConversionKata.Rgb(r,g,b));

                stringBuilder.Clear();
            }
        }
    }
}