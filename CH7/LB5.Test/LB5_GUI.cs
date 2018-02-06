using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB5.Test
{
    [TestClass]
    public class LB5_GUI
    {
        [TestMethod]
        public void GPA40_TEST80()
        {
            using (var form = new AdmissionForm())
            {
                form.Show();
                form.txtGpa.Text = "4.0";
                form.txtTestScore.Text = "80";
                form.btnAdmit.PerformClick();
                
                Assert.AreEqual("Accept", form.lblAccepted.Text);
            }
        }

        [TestMethod]
        public void GPA00_TEST00()
        {
            using (var form = new AdmissionForm())
            {
                form.Show();
                form.txtGpa.Text = "0.0";
                form.txtTestScore.Text = "00";
                form.btnAdmit.PerformClick();

                Assert.AreEqual("Reject", form.lblAccepted.Text);
            }
        }
    }
}
