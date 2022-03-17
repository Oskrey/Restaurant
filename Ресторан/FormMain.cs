using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


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
            Hide();
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

        private void buttonPriceList_Click(object sender, EventArgs e)
        {
            try
            {
                ClassTotal.excelApplication = new Excel.Application();
                // ClassTotal.excelApp.Visible = false;
                Start.startExel();
                excell = true;
            }

            catch
            {
                MessageBox.Show("Нет MS Excel");
            }
            ClassTotal.excelApplication.Visible = true;
        }
        bool excell = false;

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (excell)
            {
                ClassTotal.excelApplication.Quit();      //Выйти из Excel
                                                         //Уничтожить все COM-объекты
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(ClassTotal.excelApplication);
                //Заставляет сборщик мусора провести сборку мусора
                GC.Collect();
            }
        }
    }
}
