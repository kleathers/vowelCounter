using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5
{
    public partial class AdmissionForm : Form
    {
        public AdmissionForm()
        {
            InitializeComponent();
            lblAccepted.Text = "";
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            
            double GPA = Convert.ToDouble(txtGpa.Text);
            double testScore = Convert.ToDouble(txtTestScore.Text);
            bool adminScore = IsStudentAccepted(GPA, testScore);
           
            if(adminScore == true)
            {
                lblAccepted.Text = string.Format("Accept");
            }
            else
            {
                lblAccepted.Text = string.Format("Reject");
            }


        }
        public bool IsStudentAccepted(double GPA, double testScore)
        {
            
            if ((GPA >= 3.0 && testScore >= 60.0) || testScore >= 80.0)
            {
                return true;
            }

            else
            {
                return false;
            }
            
        }
        
    }
}
