using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB7.Test
{
    [TestClass]
    public class LB7_CountCorners
    {
        #region utils

        private void RunTest(string phrase, int expectedCorners)
        {
            using (var form = new CornersForm())
            {
                string originalPhrase = form.txtPhrase.Text;
                string originalCorners = form.lblCorners.Text;

                int actual = form.CountCorners(phrase);
                Assert.AreEqual(expectedCorners, actual);

                if (originalPhrase != form.txtPhrase.Text)
                {
                    Assert.Fail("SIDE EFFECT: txtPhrase.Text changed");
                }
                if (originalCorners != form.lblCorners.Text)
                {
                    Assert.Fail("SIDE EFFECT: lblCorners.Text changed");
                }
            }
        }

        #endregion
        
        [TestMethod]
        public void zero_has_0_corners()
        {
            RunTest("000", 0);
        }

        [TestMethod]
        public void one_has_0_corners()
        {
            RunTest("111", 0);
        }

        [TestMethod]
        public void two_has_1_corner()
        {
            RunTest("222", 3);
        }

        [TestMethod]
        public void three_has_1_corner()
        {
            RunTest("333", 3);
        }

        [TestMethod]
        public void four_has_6_corners()
        {
            RunTest("444", 18);
        }

        [TestMethod]
        public void five_has_2_corners()
        {
            RunTest("555", 6);
        }

        [TestMethod]
        public void six_has_2_corners()
        {
            RunTest("666", 6);
        }

        [TestMethod]
        public void seven_has_1_corner()
        {
            RunTest("777", 3);
        }

        [TestMethod]
        public void eight_has_2_corners()
        {
            RunTest("888", 6);
        }
        
        [TestMethod]
        public void nine_has_2_corners()
        {
            RunTest("999", 6);
        }

        [TestMethod]
        public void test_0123456789()
        {
            RunTest("0123456789", 17);
        }

        [TestMethod]
        public void test_9876543210()
        {
            RunTest("9876543210", 17);
        }

        [TestMethod]
        public void enter_two_numbers()
        {
            using (var form = new CornersForm())
            {
                Assert.AreEqual(18, form.CountCorners("444"));
                Assert.AreEqual(17, form.CountCorners("0123456789"));

                form.Show();
            }
        }
    }
}
