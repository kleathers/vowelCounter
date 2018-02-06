using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB8.Test
{
    [TestClass]
    public class LB8_CalculatePaintEstimate
    {
        #region utils

        private void RunTest(
            double area, double cost)
        {
            using (var form = new PaintingForm())
            {
                string originalLength = form.txtLength.Text;
                string originalWidth = form.txtWidth.Text;
                string originalArea = form.lblTotalArea.Text;
                string originalCost = form.lblTotalCost.Text;

                Assert.AreEqual(cost, form.CalculatePaintEstimate(area));

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
        public void A100()
        {
            RunTest(
                area: 100.0,
                cost: 600.0
            );
        }

        [TestMethod]
        public void A1000()
        {
            RunTest(
                area: 1000.0,
                cost: 6000.0
            );
        }

        [TestMethod]
        public void A10000()
        {
            RunTest(
                area: 10000.0,
                cost: 60000.0
            );
        }
    }
}
