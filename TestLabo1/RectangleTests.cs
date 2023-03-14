using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaLibrairieForme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void CoordonneeEstDansTest()
        {
            Coordonnee coord = new(7, 5);
            Rectangle rectangle = new(2, 3, 6, 3);

            Assert.IsTrue(rectangle.CoordonneeEstDans(coord));
        }

        [TestMethod()]
        public void CoordonneeEstDansTest1()
        {
            Coordonnee coord = new(6, 1);
            Rectangle rectangle = new(5, 2, 4, 2);

            Assert.IsFalse(rectangle.CoordonneeEstDans(coord));
        }
    }
}
