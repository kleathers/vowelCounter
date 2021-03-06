﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB9.Test
{
    [TestClass]
    public class LB9_GetWood
    {
        #region utils

        private void RunTest(string expected, string input)
        {
            using (var form = new DeskForm())
            {
                form.txtWoodType.Text = input;

                string originalWoodType = form.txtWoodType.Text;
                string originalDrawerCount = form.txtDrawerCount.Text;
                string originalWoodCost = form.lblWoodCost.Text;
                string originalDrawerCost = form.lblDrawerCost.Text;
                string originalTotalCost = form.lblTotalCost.Text;

                Assert.AreEqual(expected, form.GetWood());

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
        public void enter_m()
        {
            RunTest("mahogany", "m");
        }

        [TestMethod]
        public void enter_o()
        {
            RunTest("oak", "o");
        }

        [TestMethod]
        public void enter_p()
        {
            RunTest("pine", "p");
        }

        [TestMethod]
        public void enter_x()
        {
            RunTest("other", "x");
        }
    }
}
