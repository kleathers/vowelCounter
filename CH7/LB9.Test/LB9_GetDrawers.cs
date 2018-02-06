using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB9.Test
{
    [TestClass]
    public class LB9_GetDrawers
    {
        #region utils

        private void RunTest(int expected, string input)
        {
            using (var form = new DeskForm())
            {
                form.txtDrawerCount.Text = input;

                string originalWoodType = form.txtWoodType.Text;
                string originalDrawerCount = form.txtDrawerCount.Text;
                string originalWoodCost = form.lblWoodCost.Text;
                string originalDrawerCost = form.lblDrawerCost.Text;
                string originalTotalCost = form.lblTotalCost.Text;

                Assert.AreEqual(expected, form.GetDrawers());

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
            RunTest(0, "0");
        }

        [TestMethod]
        public void enter_1()
        {
            RunTest(1, "1");
        }

        [TestMethod]
        public void enter_2()
        {
            RunTest(2, "2");
        }

        [TestMethod]
        public void enter_3()
        {
            RunTest(3, "3");
        }
    }
}
