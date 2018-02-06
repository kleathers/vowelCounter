using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB9.Test
{
    [TestClass]
    public class LB9_CalculateWoodCost
    {
        #region utils

        private void RunTest(double woodCost, string woodType)
        {
            using (var form = new DeskForm())
            {
                string originalWoodType = form.txtWoodType.Text;
                string originalDrawerCount = form.txtDrawerCount.Text;
                string originalWoodCost = form.lblWoodCost.Text;
                string originalDrawerCost = form.lblDrawerCost.Text;
                string originalTotalCost = form.lblTotalCost.Text;

                Assert.AreEqual(woodCost, form.CalculateWoodCost(woodType));

                if (originalWoodType != form.txtWoodType.Text)
                {
                    Assert.Fail("SIDE EFFECT: txtWoodType.Text changed");
                }
                if (originalDrawerCount != form.txtDrawerCount.Text)
                {
                    Assert.Fail("SIDE EFFECT: txtDrawerCount.Text changed");
                }
                if (originalWoodCost != form.lblWoodCost.Text)
                {
                    Assert.Fail("SIDE EFFECT: lblWoodCost.Text changed");
                }
                if (originalDrawerCost != form.lblDrawerCost.Text)
                {
                    Assert.Fail("SIDE EFFECT: lblDrawerCost.Text changed");
                }
                if (originalTotalCost != form.lblTotalCost.Text)
                {
                    Assert.Fail("SIDE EFFECT: lblTotalCost.Text changed");
                }
            }
        }

        #endregion

        [TestMethod]
        public void enter_mahogany()
        {
            RunTest(180.0, "mahogany");
        }

        [TestMethod]
        public void enter_oak()
        {
            RunTest(140.0, "oak");
        }

        [TestMethod]
        public void enter_pine()
        {
            RunTest(100.0, "pine");
        }

        [TestMethod]
        public void enter_other()
        {
            RunTest(180.0, "other");
        }

        [TestMethod]
        public void enter_x()
        {
            RunTest(180.0, "x");
        }
    }
}
