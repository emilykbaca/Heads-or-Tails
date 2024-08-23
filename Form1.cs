// Programmer Emily Baca
// CIS 3000
// Purpose: Display heads or tails through Visible property

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showHeadsButton_Click(object sender, EventArgs e)
        {
            headsPictureBox.Visible = true;// displays the heads image
            tailsPictureBox.Visible = false;// does not display the tails image
        }

        private void showTailsButton_Click(object sender, EventArgs e)
        {
            tailsPictureBox.Visible = true;// displays the tails image
            headsPictureBox.Visible = false;// does not display the heads image
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();// exits the form
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
