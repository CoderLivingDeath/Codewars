using CodewarsTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTasksMSTests
{
    [TestClass]
    public class RectangleIntoSquaresKataTests
    {
        [TestMethod]
        public void RegularTest()
        {
            List<int> r = new List<int> { 3, 2, 1, 1 };
            var arr = RectangleIntoSquaresKata.sqInRect(5, 3);
            arr.Sort();
            Assert.AreEqual(r, arr ,"Expected: " + string.Join(", ", r.Select(n => n.ToString())));
        }

        [TestMethod]
        public void NullTest()
        {
            Assert.AreEqual(null, RectangleIntoSquaresKata.sqInRect(5, 5));
        }
    }
}
