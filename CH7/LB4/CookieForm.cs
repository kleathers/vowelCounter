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
        public string[] sayings = new string[8]
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
            var result = GenerateFortune();
            
            lblFortunes.Text = result.fortune1 + "\n\n" + result.fortune2;
        }
        
        public (string fortune1, string fortune2) GenerateFortune()
        {
            //int index1 = rand.Next(0, sayings.Length);
            //int index2 = rand.Next(0, sayings.Length - 1);
            //if (index2 >= index1)
            //{
            //    index2 += 1;
            //}
            //return (sayings[index1], sayings[index2]);

            Shuffle(sayings);
            return (sayings[0], sayings[1]);
        }
        // Rearrange an array into a random order
        public void Shuffle(string[] things)
        {
            for (int i = 0; i < things.Length; ++i)
            {
                //Pick a random item
                int other = rand.Next(i, things.Length);
                //Swap items around
                string temp = things[i];
                things[i] = things[other];
                things[other] = temp;
            }
        }
    }
}
