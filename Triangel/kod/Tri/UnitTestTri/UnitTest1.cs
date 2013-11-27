using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {
        //Testar likbent triangel
        [TestMethod]
        public void isIsoscelesTestTrue()
        {
            Triangle tri = new Triangle(5.0, 5.0, 6.0);
            Assert.IsTrue(tri.isIsosceles());
        }
        [TestMethod]
        public void isIsoscelesTestFalse()
        {
            Triangle tri = new Triangle(5.0, 5.0, 5.0);
            Assert.IsFalse(tri.isIsosceles());
        }
        //Testar liksidig triangel
        [TestMethod]
        public void isEquilateralTestTrue()
        {
            Triangle tri = new Triangle(10.0, 10.0, 10.0);
            Assert.IsTrue(tri.isEquilateral());
        }
        [TestMethod]
        public void isEquilateralTestFalse()
        {
            Triangle tri = new Triangle(10.0, 5.0, 5.0);
            Assert.IsFalse(tri.isEquilateral());
        }
        //Testar triangel utan lika sidor
        [TestMethod]
        public void isScaleneTestTrue()
        {
            Triangle tri = new Triangle(9.0, 8.0, 7.0);
            Assert.IsTrue(tri.isScalene());
        }
        [TestMethod]
        public void isScaleneTestFalse()
        {
            Triangle tri = new Triangle(9.0, 9.0, 8.0);
            Assert.IsFalse(tri.isScalene());
        }

        //Testar konstruktorn med point a, b, c
        [TestMethod]
        public void isIsoscelesTestPoints()
        {
            Triangle tri = new Triangle(new Point(0, 0), new Point(10, 0), new Point(10, 10));
            Assert.IsTrue(tri.isIsosceles());
        }
        //Testar konstruktorn med point array
        [TestMethod]
        public void isIsoscelesTestPointsArray()
        {
            Point[] pointArr = new Point[] { new Point { x = 0, y = 0 }, new Point { x = 0, y = 10 }, new Point { x = 10, y = 10 } };
            Triangle tri = new Triangle(pointArr);
            Assert.IsTrue(tri.isIsosceles());
        }
        //Testar konstruktorn med double array
        [TestMethod]
        public void isEquilateralTestDoubleArray()
        {
            Double[] doubleArray = new Double[] { 10.0, 10.0, 10.0 };
            Triangle tri = new Triangle(doubleArray);
            Assert.IsTrue(tri.isEquilateral());
        }
    }
}
