using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class FormOrder : Form
    {

        public FormMain form_main = new FormMain();

        public FormOrder()
        {
            InitializeComponent();
        }

        private void buttonIssueOrder_Click(object sender, EventArgs e)
        {
            FormCheck form_check = new FormCheck();
            this.Hide();
            form_check.Show();
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            this.Close();
            form_main.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain form_main = new FormMain();
            this.Close();
            form_main.Show();
        }
    }
}
