using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB8.Test
{
    [TestClass]
    public class LB8_GUI
    {
        #region utils

        private void RunTest(
            string length, string width, string area, string cost)
        {
            using (var form = new PaintingForm())
            {
                form.Show();
                form.txtLength.Text = length;
                form.txtWidth.Text = width;
                form.btnCalculate.PerformClick();

                Assert.AreEqual(area, form.lblTotalArea.Text);
                Assert.AreEqual(cost, form.lblTotalCost.Text);
            }
        }

        #endregion

        [TestMethod]
        public void L10_W10()
        {
            RunTest(
                length: "10",
                width: "10",
                area: "360.0",
                cost: "$2,160.00"
            );
        }

        [TestMethod]
        public void L30_W40()
        {
            RunTest(
                length: "30.0",
                width: "40.0",
                area: "1260.0",
                cost: "$7,560.00"
            );
        }

        [TestMethod]
        public void L100_W100()
        {
            RunTest(
                length: "100.0",
                width: "100.0",
                area: "3600.0",
                cost: "$21,600.00"
            );
        }
    }
}
