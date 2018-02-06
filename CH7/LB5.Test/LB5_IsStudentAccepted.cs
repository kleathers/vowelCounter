using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB5.Test
{
    [TestClass]
    public class LB5_IsStudentAccepted
    {
        #region Utils
        private void RunTest(bool expected, double gpa, int score)
        {
            using (var form = new AdmissionForm())
            {
                string originalGpa = form.txtGpa.Text;
                string originalScore = form.txtTestScore.Text;
                string originalAccept = form.lblAccepted.Text;

                bool actual = form.IsStudentAccepted(gpa, score);
                Assert.AreEqual(expected, actual);

                if (originalGpa != form.txtGpa.Text)
                {
                    Assert.Fail("SIDE EFFECT: txtGpa.Text changed");
                }
                if (originalScore != form.txtTestScore.Text)
                {
                    Assert.Fail("SIDE EFFECT: txtTestScore.Text changed");
                }
                if (originalAccept != form.lblAccepted.Text)
                {
                    Assert.Fail("SIDE EFFECT: lblAccepted.Text changed");
                }
            }
        }
        #endregion

        [TestMethod]
        public void GPA40_TEST80()
        {
            RunTest(
                expected: true,
                gpa: 4.0,
                score: 80
            );
        }

        [TestMethod]
        public void GPA40_TEST60()
        {
            RunTest(
                expected: true,
                gpa: 4.0,
                score: 60
            );
        }

        [TestMethod]
        public void GPA40_TEST40()
        {
            RunTest(
                expected: false,
                gpa: 4.0,
                score: 40
            );
        }

        [TestMethod]
        public void GPA35_TEST80()
        {
            RunTest(
                expected: true,
                gpa: 3.5,
                score: 80
            );
        }

        [TestMethod]
        public void GPA35_TEST60()
        {
            RunTest(
                expected: true,
                gpa: 3.5,
                score: 60
            );
        }

        [TestMethod]
        public void GPA35_TEST40()
        {
            RunTest(
                expected: false,
                gpa: 3.5,
                score: 40
            );
        }

        [TestMethod]
        public void GPA30_TEST80()
        {
            RunTest(
                expected: true,
                gpa: 3.0,
                score: 80
            );
        }

        [TestMethod]
        public void GPA30_TEST60()
        {
            RunTest(
                expected: true,
                gpa: 3.0,
                score: 60
            );
        }

        [TestMethod]
        public void GPA30_TEST40()
        {
            RunTest(
                expected: false,
                gpa: 3.0,
                score: 40
            );
        }

        [TestMethod]
        public void GPA25_TEST80()
        {
            RunTest(
                expected: true,
                gpa: 2.5,
                score: 80
            );
        }

        [TestMethod]
        public void GPA25_TEST60()
        {
            RunTest(
                expected: false,
                gpa: 2.5,
                score: 60
            );
        }

        [TestMethod]
        public void GPA25_TEST40()
        {
            RunTest(
                expected: false,
                gpa: 2.5,
                score: 40
            );
        }

        [TestMethod]
        public void GPA00_TEST00()
        {
            RunTest(
                expected: false,
                gpa: 0.0,
                score: 0
            );
        }
    }
}
