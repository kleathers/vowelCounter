using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB8.Test
{
    [TestClass]
    public class LB8_CalculateTotalArea
    {
        #region utils

        private void RunTest(
            double length, double width, double area)
        {
            using (var form = new PaintingForm())
            {
                string originalLength = form.txtLength.Text;
                string originalWidth = form.txtWidth.Text;
                string originalArea = form.lblTotalArea.Text;
                string originalCost = form.lblTotalCost.Text;

                Assert.AreEqual(area, form.CalculateTotalArea(length, width));

                if (originalLength != form.txtLength.Text)
                {
                    Assert.Fail("SIDE EFFECT: txtLength.Text changed");
                }
                if (originalWidth != form.txtWidth.Text)
                {
                    Assert.Fail("SIDE EFFECT: txtWidth.Text changed");
                }
                if (originalArea != form.lblTotalArea.Text)
                {
                    Assert.Fail("SIDE EFFECT: lblTotalArea.Text changed");
                }
                if (originalCost != form.lblTotalCost.Text)
                {
                    Assert.Fail("SIDE EFFECT: lblTotalCost.Text changed");
                }
            }
        }

        #endregion

        [TestMethod]
        public void L10_W10()
        {
            RunTest(
                length: 10,
                width: 10,
                area: 360.0
            );
        }

        [TestMethod]
        public void L30_W40()
        {
            RunTest(
                length: 30.0,
                width: 40.0,
                area: 1260.0
            );
        }

        [TestMethod]
        public void L40_W30()
        {
            RunTest(
                length: 40.0,
                width: 30.0,
                area: 1260.0
            );
        }

        [TestMethod]
        public void L100_W100()
        {
            RunTest(
                length: 100.0,
                width: 100.0,
                area: 3600.0
            );
        }
    }
}
