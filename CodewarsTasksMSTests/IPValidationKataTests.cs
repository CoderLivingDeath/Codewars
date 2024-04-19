using CodewarsTasks;

namespace CodewarsTasksMSTests
{
    [TestClass]
    public class IPValidationIPValidationIPValidationKataTests
    {
        [TestMethod]
        public void IsValidIpMethodTest()
        {
            Assert.AreEqual(true, IPValidationKata.IsValidIp("0.0.0.0"));
            Assert.AreEqual(true, IPValidationKata.IsValidIp("12.255.56.1"));
            Assert.AreEqual(true, IPValidationKata.IsValidIp("137.255.156.100"));

            Assert.AreEqual(false, IPValidationKata.IsValidIp(""));
            Assert.AreEqual(false, IPValidationKata.IsValidIp("abc.def.ghi.jkl"));
            Assert.AreEqual(false, IPValidationKata.IsValidIp("123.456.789.0"));
            Assert.AreEqual(false, IPValidationKata.IsValidIp("12.34.56"));
            Assert.AreEqual(false, IPValidationKata.IsValidIp("12.34.56.00"), "For IP: 12.34.56.00 .");
            Assert.AreEqual(false, IPValidationKata.IsValidIp("12.34.56.7.8"));
            Assert.AreEqual(false, IPValidationKata.IsValidIp("12.34.256.78"));
            Assert.AreEqual(false, IPValidationKata.IsValidIp("1234.34.56"));
            Assert.AreEqual(false, IPValidationKata.IsValidIp("pr12.34.56.78"));
            Assert.AreEqual(false, IPValidationKata.IsValidIp("12.34.56.78sf"));
            Assert.AreEqual(false, IPValidationKata.IsValidIp("12.34.56 .1"));
            Assert.AreEqual(false, IPValidationKata.IsValidIp("12.34.56.-1"));
            Assert.AreEqual(false, IPValidationKata.IsValidIp("123.045.067.089"));
        }
    }
}
