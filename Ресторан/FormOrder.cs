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

        private void FormOrder_Load(object sender, EventArgs e)
        {

            ClassTotal.excelSheet = (Excel.Worksheet)ClassTotal.excelBook.Worksheets.get_Item("Категории");
            ClassTotal.excelSheet = (Excel.Worksheet)ClassTotal.excelBook.Sheets.get_Item("Категории");
            ClassTotal.excelSheet = (Excel.Worksheet)ClassTotal.excelBook.Worksheets["Категории"];
            ClassTotal.excelSheet = (Excel.Worksheet)ClassTotal.excelBook.Sheets[1];




            //Получит все заполненные ячейки
            ClassTotal.excelCells = ClassTotal.excelSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            //Количество=номеру последней заполненной ячейки
            int count = ClassTotal.excelCells.Row;
            //Перенос в список

            this.listBoxCat.Items.Clear();
            for (int i = 1; i <= count; i++)
            {
                ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 1];  //Ссылка на нужную ячейку
                if (ClassTotal.excelCells != null)
                {
                    this.listBoxCat.Items.Add(ClassTotal.excelCells.Value2);  //Значение этой ячейки
                }
            }
        }
    }
}
