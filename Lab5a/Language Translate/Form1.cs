using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Translate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            translationLebel.Text = "Buongiorno";
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            translationLebel.Text = "Guten Morgen";
        }

        private void SpanishButton_Click(object sender, EventArgs e)
        {
            translationLebel.Text = "Buenos Dias";
        }
    }
}
