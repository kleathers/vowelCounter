using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB7.Test
{
    [TestClass]
    public class LB7_GUI
    {
        #region constants

        private const string CORNERS = "There are {0} corners in your number";

        #endregion
        #region utils

        private void RunTest(string phrase, int expectedCorners)
        {
            using (var form = new CornersForm())
            {
                form.Show();
                form.txtPhrase.Text = phrase;
                form.btnEnter.PerformClick();

                Assert.AreEqual(string.Format(CORNERS, expectedCorners), form.lblCorners.Text);
            }
        }

        #endregion

        [TestMethod]
        public void test_1()
        {
            RunTest("1", 0);
        }

        [TestMethod]
        public void test_4()
        {
            RunTest("4", 6);
        }

        [TestMethod]
        public void test_0123456789()
        {
            RunTest("0123456789", 17);
        }

        [TestMethod]
        public void enter_two_numbers()
        {
            using (var form = new CornersForm())
            {
                form.Show();

                form.txtPhrase.Text = "444";
                form.btnEnter.PerformClick();
                Assert.AreEqual(string.Format(CORNERS, 18), form.lblCorners.Text);

                form.txtPhrase.Text = "0123456789";
                form.btnEnter.PerformClick();
                Assert.AreEqual(string.Format(CORNERS, 17), form.lblCorners.Text);
            }
        }
    }
}
