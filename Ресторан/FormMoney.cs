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
    public partial class FormMoney : Form
    {

        Random rnd = new Random();

        public FormMoney()
        {
            InitializeComponent();
        }

        private void FormMoney_Load(object sender, EventArgs e)
        {
            labelMoney.Text = Convert.ToString(rnd.Next(1000, 100000));
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FormOrder form_order = new FormOrder();
            this.Close();
            form_order.Show();
        }
    }
}
