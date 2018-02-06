using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB6.Test
{
    [TestClass]
    public class LB6_GUI
    {
        #region constants

        private const string VOWELS = "There are {0} vowels in your phrase";

        #endregion
        #region utils

        private void RunTest(string phrase, int expectedVowels)
        {
            using (var form = new VowelsForm())
            {
                form.Show();
                form.txtPhrase.Text = phrase;
                form.btnEnter.PerformClick();

                Assert.AreEqual(string.Format(VOWELS, expectedVowels), form.lblVowels.Text);
            }
        }

        #endregion
        
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
                form.Show();

                form.txtPhrase.Text = "AEIOUY";
                form.btnEnter.PerformClick();
                Assert.AreEqual(string.Format(VOWELS, 5), form.lblVowels.Text);

                form.txtPhrase.Text = "The Quick Brown Fox Jumps Over The Lazy Dog";
                form.btnEnter.PerformClick();
                Assert.AreEqual(string.Format(VOWELS, 11), form.lblVowels.Text);
            }
        }
    }
}
