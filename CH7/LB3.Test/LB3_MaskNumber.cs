using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB3.Test
{
    [TestClass]
    public class LB3_MaskNumber
    {
        #region Utils
        private void RunTest(
            string expected, string original, char replacementChar, int preserveLength)
        {
            using (var form = new CreditMaskerForm())
            {
                string originalRaw = form.txtRaw.Text;
                string originalMask = form.lblMasked.Text;

                string actual = form.MaskNumber(original, replacementChar, preserveLength);
                Assert.AreEqual(expected, actual);

                if (originalRaw != form.txtRaw.Text)
                {
                    Assert.Fail("SIDE EFFECT: txtRaw.Text changed");
                }
                if (originalMask != form.lblMasked.Text)
                {
                    Assert.Fail("SIDE EFFECT: lblMasked.Text changed");
                }
            }
        }
        #endregion

        [TestMethod]
        public void mask_4534_1313_1233_1213__HASH4()
        {
            RunTest(
                expected: "#### #### #### 1213",
                original: "4534 1313 1233 1213",
                replacementChar: '#',
                preserveLength: 4
            );
        }

        [TestMethod]
        public void mask_4534_1313_1233_1213__X3()
        {
            RunTest(
                expected: "XXXX XXXX XXXX X213",
                original: "4534 1313 1233 1213",
                replacementChar: 'X',
                preserveLength: 3
            );
        }

        [TestMethod]
        public void mask_12__X4()
        {
            RunTest(
                expected: "12",
                original: "12",
                replacementChar: 'X',
                preserveLength: 4
            );
        }

        [TestMethod]
        public void mask_AB__X4()
        {
            RunTest(
                expected: "AB",
                original: "AB",
                replacementChar: 'X',
                preserveLength: 4
            );
        }

        [TestMethod]
        public void mask_1234__X4()
        {
            RunTest(
                expected: "1234",
                original: "1234",
                replacementChar: 'X',
                preserveLength: 4
            );
        }

        [TestMethod]
        public void mask_ABCD__X4()
        {
            RunTest(
                expected: "ABCD",
                original: "ABCD",
                replacementChar: 'X',
                preserveLength: 4
            );
        }

        [TestMethod]
        public void mask_1234_5678__X4()
        {
            RunTest(
                expected: "XXXX 5678",
                original: "1234 5678",
                replacementChar: 'X',
                preserveLength: 4
            );
        }

        [TestMethod]
        public void mask_ABCD_EFGH__X4()
        {
            RunTest(
                expected: "XXXX EFGH",
                original: "ABCD EFGH",
                replacementChar: 'X',
                preserveLength: 4
            );
        }

        [TestMethod]
        public void mask_1234_5678__H4()
        {
            RunTest(
                expected: "HHHH 5678",
                original: "1234 5678",
                replacementChar: 'H',
                preserveLength: 4
            );
        }

        [TestMethod]
        public void mask_ABCD_EFGH__H4()
        {
            RunTest(
                expected: "HHHH EFGH",
                original: "ABCD EFGH",
                replacementChar: 'H',
                preserveLength: 4
            );
        }

        [TestMethod]
        public void mask_1234_5678__X3()
        {
            RunTest(
                expected: "XXXX X678",
                original: "1234 5678",
                replacementChar: 'X',
                preserveLength: 3
            );
        }

        [TestMethod]
        public void mask_ABCD_EFGH__X3()
        {
            RunTest(
                expected: "XXXX XFGH",
                original: "ABCD EFGH",
                replacementChar: 'X',
                preserveLength: 3
            );
        }

        [TestMethod]
        public void mask_1234_5678__X2()
        {
            RunTest(
                expected: "XXXX XX78",
                original: "1234 5678",
                replacementChar: 'X',
                preserveLength: 2
            );
        }

        [TestMethod]
        public void mask_ABCD_EFGH__X2()
        {
            RunTest(
                expected: "XXXX XXGH",
                original: "ABCD EFGH",
                replacementChar: 'X',
                preserveLength: 2
            );
        }

        [TestMethod]
        public void mask_1234_5678__X1()
        {
            RunTest(
                expected: "XXXX XXX8",
                original: "1234 5678",
                replacementChar: 'X',
                preserveLength: 1
            );
        }

        [TestMethod]
        public void mask_ABCD_EFGH__X1()
        {
            RunTest(
                expected: "XXXX XXXH",
                original: "ABCD EFGH",
                replacementChar: 'X',
                preserveLength: 1
            );
        }

        [TestMethod]
        public void hack_the_matrix()
        {
            RunTest(
                expected: "XXXX XXXX XXXX {12}",
                original: "{12} {12} {12} {12}",
                replacementChar: 'X',
                preserveLength: 4
            );
        }

        [TestMethod]
        public void enter_two_numbers()
        {
            using (var form = new CreditMaskerForm())
            {
                Assert.AreEqual("YYYY YFGH", form.MaskNumber("ABCD EFGH", 'Y', 3));
                Assert.AreEqual("ZZZZ 5678", form.MaskNumber("1234 5678", 'Z', 4));
            }
        }
    }
}
