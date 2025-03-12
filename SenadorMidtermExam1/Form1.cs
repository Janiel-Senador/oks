using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenadorMidtermExam1
{
    public partial class Form1 : Form
    {
        private int yesVotes = 0;
        private int noVotes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVoteYes_Click(object sender, EventArgs e)
        {
            yesVotes++;
            MessageBox.Show("You voted Yes!");
        }

        private void btnVoteNo_Click(object sender, EventArgs e)
        {
            noVotes++;
            MessageBox.Show("You voted No!");
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            if (yesVotes >= 2)
            {
                lblResult.Text = "Decision: Yes";
            }
            else if (noVotes >= 2)
            {
                lblResult.Text = "Decision: No";
            }
            else
            {
                lblResult.Text = "Invalid input";
            }
        }
    }
}
