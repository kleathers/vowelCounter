using System;
using System.Windows.Forms;

namespace LB4
{
    public partial class CookieForm : Form
    {
        public CookieForm()
        {
            InitializeComponent();
        }

        public Random rand = new Random();
        public string[] sayings = 
        {
            "Birthdays are like friends. The more you have the better.",
            "Your smile is a treasure to all who know you.",
            "You never hesitate to tackle the most difficult problems.",
            "The most obvious solution is not always the best.",
            "If you want the rainbow, you will have to tolerate the rain.",
            "The early bird gets the worm, but the second mouse gets the cheese.",
            "From listening comes wisdom and from speaking repentance.",
            "A smile is your personal welcome mat.",
        };

        private void btnOpen_Click(object sender, EventArgs e)
        {
        }
        
        // Rearrange an array into a random order
        public void Shuffle(string[] things)
        {
            // TODO
        }
    }
}
