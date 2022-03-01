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
    public partial class FormCheck : Form
    {

        FormOrder form_order = new FormOrder();

        public FormCheck()
        {
            InitializeComponent();
        }

        private void buttonMakeCheck_Click(object sender, EventArgs e)
        {
            form_order.Close();
        }

        private void buttonMain_Click(object sender, EventArgs e)
        { 
            this.Close();
            form_order.Show();
        }

        private void pictureBoxIcon_Click(object sender, EventArgs e)
        {
            FormMain form_main = new FormMain();
            this.Close();
            form_main.Show();
        }
    }
}
