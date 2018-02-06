using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB9.Test
{
    [TestClass]
    public class LB9_GUI
    {
        #region utils

        private void RunTest(
            string woodType, int drawerCount,
            double woodCost, double drawerCost, double totalCost)
        {
            using (var form = new DeskForm())
            {
                form.Show();
                form.txtWoodType.Text = woodType;
                form.txtDrawerCount.Text = drawerCount.ToString();
                form.btnEstimate.PerformClick();

                Assert.AreEqual(woodCost.ToString("C"), form.lblWoodCost.Text, "Cost of Wood is incorrect");
                Assert.AreEqual(drawerCost.ToString("C"), form.lblDrawerCost.Text, "Cost of Drawers is incorrect");
                Assert.AreEqual(totalCost.ToString("C"), form.lblTotalCost.Text, "Total Cost is incorrect");
            }
        }

        #endregion

        [TestMethod]
        public void mahogany_3()
        {
            RunTest(
                woodType: "m",
                drawerCount: 3,
                woodCost: 180,
                drawerCost: 90,
                totalCost: 270
            );
        }

        [TestMethod]
        public void oak_4()
        {
            RunTest(
                woodType: "o",
                drawerCount: 4,
                woodCost: 140,
                drawerCost: 120,
                totalCost: 260
            );
        }

        [TestMethod]
        public void pine_5()
        {
            RunTest(
                woodType: "p",
                drawerCount: 5,
                woodCost: 100,
                drawerCost: 150,
                totalCost: 250
            );
        }

        [TestMethod]
        public void other_6()
        {
            RunTest(
                woodType: "x",
                drawerCount: 6,
                woodCost: 180,
                drawerCost: 180,
                totalCost: 360
            );
        }
    }
}
