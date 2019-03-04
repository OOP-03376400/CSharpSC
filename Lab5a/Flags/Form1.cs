using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void finlandBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Finland";
        }

        private void franceBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "France";
        }

        private void germanyBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Germany";
        }
    }
}
