using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB6.Test
{
    [TestClass]
    public class LB6_CountVowels
    {
        #region utils

        private void RunTest(string phrase, int expectedVowels)
        {
            using (var form = new VowelsForm())
            {
                string originalPhrase = form.txtPhrase.Text;
                string originalVowels = form.lblVowels.Text;

                int actual = form.CountVowels(phrase);
                Assert.AreEqual(expectedVowels, actual);

                if (originalPhrase != form.txtPhrase.Text)
                {
                    Assert.Fail("SIDE EFFECT: txtPhrase.Text changed");
                }
                if (originalVowels != form.lblVowels.Text)
                {
                    Assert.Fail("SIDE EFFECT: lblVowels.Text changed");
                }
            }
        }

        #endregion

        [TestMethod]
        public void aaa_has_3_vowels()
        {
            RunTest("aaa", 3);
        }

        [TestMethod]
        public void eee_has_3_vowels()
        {
            RunTest("eee", 3);
        }

        [TestMethod]
        public void iii_has_3_vowels()
        {
            RunTest("iii", 3);
        }

        [TestMethod]
        public void ooo_has_3_vowels()
        {
            RunTest("ooo", 3);
        }

        [TestMethod]
        public void uuu_has_3_vowels()
        {
            RunTest("uuu", 3);
        }

        [TestMethod]
        public void yyy_has_zero_vowels()
        {
            RunTest("yyy", 0);
        }

        [TestMethod]
        public void xyz_has_zero_vowels()
        {
            RunTest("xyz", 0);
        }

        [TestMethod]
        public void AAA_has_3_vowels()
        {
            RunTest("AAA", 3);
        }

        [TestMethod]
        public void EEE_has_3_vowels()
        {
            RunTest("EEE", 3);
        }

        [TestMethod]
        public void III_has_3_vowels()
        {
            RunTest("III", 3);
        }

        [TestMethod]
        public void OOO_has_3_vowels()
        {
            RunTest("OOO", 3);
        }

        [TestMethod]
        public void UUU_has_3_vowels()
        {
            RunTest("UUU", 3);
        }

        [TestMethod]
        public void YYY_has_zero_vowels()
        {
            RunTest("YYY", 0);
        }

        [TestMethod]
        public void XYZ_has_zero_vowels()
        {
            RunTest("XYZ", 0);
        }

        [TestMethod]
        public void aeiouy_has_5_vowels()
        {
            RunTest("aeiouy", 5);
        }

        [TestMethod]
        public void AEIOUY_has_5_vowels()
        {
            RunTest("AEIOUY", 5);
        }

        [TestMethod]
        public void quick_brown_fox_has_11_vowels()
        {
            RunTest("The Quick Brown Fox Jumps Over The Lazy Dog", 11);
        }

        [TestMethod]
        public void enter_two_phrases()
        {
            using (var form = new VowelsForm())
            {
                Assert.AreEqual(5, form.CountVowels("AEIOUY"));
                Assert.AreEqual(11, form.CountVowels("The Quick Brown Fox Jumps Over The Lazy Dog"));
            }
        }
    }
}
