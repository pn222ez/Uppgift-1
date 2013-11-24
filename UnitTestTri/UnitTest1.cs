using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void createPassingNullToDoubleArrayConstructor()
        {
            Triangle triangle = new Triangle((Double[])null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void createPassingNullToPointArrayConstructor()
        {
            Triangle triangle = new Triangle((Point[])null);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void createWithLessThanThreePoints()
        {
            Triangle triangle = new Triangle(new[] {new Point(0,0), new Point(1,1)});
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void createWithMoreThanThreePoints()
        {
            Triangle triangle = new Triangle(new[] { new Point(0, 0), new Point(1, 1), new Point(2, 2), new Point(4, 4) });
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void createWithLessThanThreeDoubles()
        {
            Triangle triangle = new Triangle(new Double[] { 2,6, 3,9 });
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void createWithEmptyPointArray()
        {
            Triangle triangle = new Triangle(new Point[] {});
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void createWithEmptyDoubleArray()
        {
            Triangle triangle = new Triangle(new Double[] { });
        }

        [TestMethod]
        public void createWithThreePoints()
        {
            Triangle triangle = new Triangle(new Point(0, 0), new Point(1,1), new Point(2,2));
        }

        [TestMethod]
        public void createWithThreeDoubles()
        {
            Triangle triangle = new Triangle(2.6, 2.8, 2.7);
        }

        [TestMethod]
        public void createPoint()
        {
            Point point = new Point(0, 0);
        }

        [TestMethod]
        public void isIsoscelesTest()
        {
            Triangle triangle = new Triangle(1, 2, 2);
            Assert.IsTrue(triangle.isIsosceles());
        }

        [TestMethod]
        public void isNotIsoscelesTest()
        {
            Triangle triangle = new Triangle(1,2,3);
            Assert.IsFalse(triangle.isIsosceles());
        }

        [TestMethod]
        public void isIscaleneTest()
        {
            Triangle triangle = new Triangle(1, 2, 3);
            Assert.IsTrue(triangle.isScalene());
        }
        [TestMethod]
        public void isNotIscaleneTest()
        {
            Triangle triangle = new Triangle(2, 2, 3);
            Assert.IsFalse(triangle.isScalene());
        }

        [TestMethod]
        public void isEquilateralTest()
        {
            Triangle triangle = new Triangle(2, 2, 2);
            Assert.IsTrue(triangle.isEquilateral());
        }

        [TestMethod]
        public void isNotEquilateralTest()
        {
            Triangle triangle = new Triangle(1, 2, 3);
            Assert.IsFalse(triangle.isEquilateral());
        }
    }
}
