using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB4.Test
{
    [TestClass]
    public class LB4_GUI
    {
        [TestMethod]
        public void smoke_test()
        {
            using (var form = new CookieForm())
            {
                string originalFortunes = form.lblFortunes.Text;

                form.Show();
                form.btnOpen.PerformClick();
                
                Assert.AreNotEqual(originalFortunes, form.lblFortunes.Text);
            }
        }
    }
}
