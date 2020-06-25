using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }
        private void OKButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                this.Hide();
            }
        }
        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void HelpText_Click(object sender, EventArgs e)
        {

        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }
    }
}