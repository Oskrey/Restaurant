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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            FormMoney form_money = new FormMoney();
            this.Hide();
            form_money.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonManageMenu_Click(object sender, EventArgs e)
        {
            FormAutorization form_autorization = new FormAutorization();
            this.Hide();
            form_autorization.ShowDialog();
        }
    }
}
