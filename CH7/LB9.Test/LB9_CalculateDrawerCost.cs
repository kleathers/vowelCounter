using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB9.Test
{
    [TestClass]
    public class LB9_CalculateDrawerCost
    {
        #region utils

        private void RunTest(double drawerCost, int drawerCount)
        {
            using (var form = new DeskForm())
            {
                string originalWoodType = form.txtWoodType.Text;
                string originalDrawerCount = form.txtDrawerCount.Text;
                string originalWoodCost = form.lblWoodCost.Text;
                string originalDrawerCost = form.lblDrawerCost.Text;
                string originalTotalCost = form.lblTotalCost.Text;

                Assert.AreEqual(drawerCost, form.CalculateDrawerCost(drawerCount));

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
        public void enter_0()
        {
            RunTest(0, 0);
        }

        [TestMethod]
        public void enter_1()
        {
            RunTest(30, 1);
        }

        [TestMethod]
        public void enter_2()
        {
            RunTest(60, 2);
        }

        [TestMethod]
        public void enter_3()
        {
            RunTest(90, 3);
        }
    }
}
