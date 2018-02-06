using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB3.Test
{
    /// <summary>
    /// Summary description for LB3_GUI
    /// </summary>
    [TestClass]
    public class LB3_GUI
    {
        [TestMethod]
        public void mask_4534_1313_1233_1213()
        {
            using (var form = new CreditMaskerForm())
            {
                form.Show();
                form.txtRaw.Text = "4534 1313 1233 1213";
                form.btnMask.PerformClick();

                string mask = form.lblMasked.Text;
                Assert.AreEqual("XXXX XXXX XXXX X213", mask);
            }
        }
    }
}
