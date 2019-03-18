using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBack_Click(object sender, EventArgs e)
        {
            cardbackBox.Visible = true;
            cardFaceBox.Visible = false;
        }

        private void showFace_Click(object sender, EventArgs e)
        {
            cardbackBox.Visible = false;
            cardFaceBox.Visible = true;
        }
    }
}
