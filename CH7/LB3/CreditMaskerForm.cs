using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public partial class CreditMaskerForm : Form
    {
        public CreditMaskerForm()
        {
            InitializeComponent();
            lblMasked.Text = "";
        }

        public const char MASK = 'X';
        public const int NUMS_LEFT = 3;

        private void btnMask_Click(object sender, EventArgs e)
        {
            string creditCardNum = Convert.ToString(txtRaw.Text);
            lblMasked.Text = MaskNumber(creditCardNum, MASK, NUMS_LEFT);
           
        }

        public string MaskNumber(string raw, char mask, int numLeft)
        {
           
            StringBuilder masked = new StringBuilder(raw.Length);

            int i = 0;
            
            for(; i < raw.Length - numLeft; ++i)
            {
                if (raw[i] == ' ')
                {
                    masked.Append(' ');
                }
                else
                {
                    masked.Append(mask);
                }
            }
            for (; i < raw.Length; ++i)
            {
                masked.Append(raw[i]);
            }
            return masked.ToString();
        }
    }
}
