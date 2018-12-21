using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleNS;

namespace TriangleNS.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleNotNullTest_TrueReturned()
        {
            var tri = new Triangle();

            Assert.IsNotNull(tri);
        }

        [TestMethod]
        public void TriangleCanBeTest_TrueReturned()
        {
            var tri = new Triangle(0, 0, 3, 0, 0, 4);

            bool flag;
            flag = tri.CanBe();

            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void TriangleLengthTest_3and4and5_TrueReturned()
        {
            var tri = new Triangle(0, 0, 3, 0, 0, 4);

            double a, b, c;
            a = tri.getAB();
            b = tri.getAC();
            c = tri.getBC();

            Assert.AreEqual(3.0, a);
            Assert.AreEqual(4.0, b);
            Assert.AreEqual(5.0, c);
        }

        [TestMethod]
        public void TrianglePerimTest_3and4and5_12returned()
        {
            var tri = new Triangle(0, 0, 3, 0, 0, 4);

            double per;
            per = tri.Perimetr();

            Assert.AreEqual(12.0, per);
        }

        [TestMethod]
        public void TriangleHightTest_3and4and5_2_4_returned()
        {
            var tri = new Triangle(0, 0, 3, 0, 0, 4);

            double hig;
            hig = tri.Hight("BC");

            Assert.AreEqual(2.4, hig);
        }

        [TestMethod]
        public void TriangleSquareTest_3and4and5_6returned()
        {
            var tri = new Triangle(0, 0, 3, 0, 0, 4);

            double sq;
            sq = tri.Square();

            Assert.AreEqual(6.0, sq);
        }

        [TestMethod]
        public void TriangleRectangledTest_TrueReturned()
        {
            var tri = new Triangle(0, 0, 3, 0, 0, 4);

            bool flag;
            flag = tri.Rectangled();

            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void TriangleIsoscelesTest_TrueReturned()
        {
            var tri = new Triangle(0, 0, 3, 0, 0, 3);

            bool flag;
            flag = tri.Isosceles();

            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void TriangleEquilateralTest_TrueReturned()
        {
            var tri = new Triangle(3, 0, 9, 0, 6, Math.Sqrt(27));

            bool flag;
            flag = tri.Equilateral();

            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void TriangleVersatileTest_TrueReturned()
        {
            var tri = new Triangle(0, 0, 7, 5, 3, 2);

            bool flag;
            flag = tri.Versatile();

            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void TriangleRectangledTest_FalseReturned()
        {
            var tri = new Triangle(0, 0, 7, 5, 3, 2);

            bool flag;
            flag = tri.Rectangled();

            Assert.IsFalse(flag);
        }

        [TestMethod]
        public void TriangleIsoscelesTest_FalseReturned()
        {
            var tri = new Triangle(0, 0, 7, 5, 3, 2);

            bool flag;
            flag = tri.Isosceles();

            Assert.IsFalse(flag);
        }

        [TestMethod]
        public void TriangleEquilateralTest_FalseReturned()
        {
            var tri = new Triangle(0, 0, 7, 5, 3, 2);

            bool flag;
            flag = tri.Equilateral();

            Assert.IsFalse(flag);
        }

        [TestMethod]
        public void TriangleVersatileTest_FalseReturned()
        {
            var tri = new Triangle(0, 0, 3, 0, 0, 3);

            bool flag;
            flag = tri.Versatile();

            Assert.IsFalse(flag);
        }
    }
}
