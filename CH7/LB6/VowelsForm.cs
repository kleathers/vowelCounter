using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB6
{
    public partial class VowelsForm : Form
    {
        public VowelsForm()
        {
            InitializeComponent();
            lblVowels.Text = "";
        }

        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int vowel = Convert.ToInt32(lblVowels.Text);
            string v = Convert.ToString(txtPhrase.Text);
            
           
        }

        public int CountVowels(string v, int vowel)
        {
            
            for (int i = 0; i < v.Length; ++i)
            {
                if (v[i] == 'a' || v[i] == 'e' || v[i] == 'i' || v[i] == 'o' || v[i] == 'u' || v[i] == 'A' || v[i] == 'E' || v[i] == 'I' || v[i] == 'O' || v[i] == 'U')
                {
                    vowel++;

                }
                lblVowels.Text = string.Format("There are {0} vowels in your phrase", vowel);
            }

        }
    }
}
