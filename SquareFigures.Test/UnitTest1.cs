using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquareFigures.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Circle_2_4Piresoult()
        {
            Square S = new Square();
            double exepted=S.Circle(3);
            double actual=9*Math.PI;
            Assert.AreEqual(exepted, actual);
        }
        [TestMethod]
        public void Treangle_2and3and4_resoult()
        {
            Square S = new Square();
            double exepted = S.Treangle(3, 4, 5);
            double actual = 6;
            Assert.AreEqual(exepted, actual);
        }
        [TestMethod]
        public void Squdre_2_4resoult()
        {
            Square S = new Square();
            double exepted = S.Squdre(2);
            double actual = 4;
            Assert.AreEqual(exepted, actual);
        }
        [TestMethod]
        public void SumFigures_4and4_8resoult()
        {
            Square S1 = new Square();
            S1.Squdre(2);
            Square S2 = new Square();
            S2.Squdre(2);
            Square S = new Square();
            double exepted = S.Figures(S1, S2);
            double actual = 8;
            Assert.AreEqual(exepted, actual);
        }
        [TestMethod]
        public void Equals_2_3_4_falseReturn()
        {
            Square S = new Square();
            bool expected = S.Equal(2, 3, 4);
            bool actual = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Rectangle_2_5_10resoult()
        {
            Square S = new Square();
            double expected = S.Rectangle(2, 5);
            double actual = 10;
            Assert.AreEqual(expected, actual);
        }
    }
}
