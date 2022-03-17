using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

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

             Money.Value = rnd.Next(1000, 100000);
            labelMoney.Text =Money.Value.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                ClassTotal.excelApplication = new Excel.Application();
                 ClassTotal.excelApplication.Visible = false;
                Start.startExel();
                FormOrder form_order = new FormOrder();
                this.Close();
                form_order.Show();
            }

            catch
            {
                MessageBox.Show("Нет MS Excel");
            }
           
        }
    }
}
