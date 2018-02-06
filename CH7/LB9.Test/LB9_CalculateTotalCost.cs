using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB9.Test
{
    [TestClass]
    public class LB9_CalculateTotalCost
    {
        #region utils

        private void RunTest(double expected, string woodType, int drawerCount)
        {
            using (var form = new DeskForm())
            {
                string originalWoodType = form.txtWoodType.Text;
                string originalDrawerCount = form.txtDrawerCount.Text;
                string originalWoodCost = form.lblWoodCost.Text;
                string originalDrawerCost = form.lblDrawerCost.Text;
                string originalTotalCost = form.lblTotalCost.Text;

                Assert.AreEqual(expected, form.CalculateTotalCost(woodType, drawerCount));

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
        public void mahogany_3()
        {
            RunTest(270, "mahogany", 3);
        }

        [TestMethod]
        public void oak_4()
        {
            RunTest(260, "oak", 4);
        }

        [TestMethod]
        public void pine_5()
        {
            RunTest(250, "pine", 5);
        }

        [TestMethod]
        public void other_6()
        {
            RunTest(360, "other", 6);
        }

        [TestMethod]
        public void x_7()
        {
            RunTest(390, "x", 7);
        }
    }
}
