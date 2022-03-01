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
    public partial class FormManageMenu : Form
    {
        public FormManageMenu()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMain form_main = new FormMain();
            this.Close();
            form_main.Show();
        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            FormMain form_main = new FormMain();
            this.Close();
            form_main.Show();
        }
    }
}
