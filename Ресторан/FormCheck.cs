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
    public partial class FormCheck : Form
    {

        FormOrder form_order = new FormOrder();

        public FormCheck()
        {
            InitializeComponent();
        }

        private void buttonMakeCheck_Click(object sender, EventArgs e)
        {
            ClassTotal.excelApplication.SheetsInNewWorkbook = 1;       //В новой книге будет один лист
            ClassTotal.excelBook = ClassTotal.excelApplication.Workbooks.Add(Type.Missing);   //Добавить новую книгу
            ClassTotal.excelApplication.DisplayAlerts = false; //Не выдавать сообщений пользователю
                                                               //Обратиться к первому листу любым способом
            ClassTotal.excelSheet = (Excel.Worksheet)ClassTotal.excelBook.Worksheets.get_Item(1); //Вариант 1
            ClassTotal.excelSheet = ClassTotal.excelBook.Worksheets[1];           //Вариант 2
            ClassTotal.excelSheet.Name = "Чек на заказ";  	 //Дать имя листу


        }

        private void buttonMain_Click(object sender, EventArgs e)
        { 
            Close();
            Form open = Application.OpenForms["FormMain"];


            open.Show();
        }

        private void FormCheck_Load(object sender, EventArgs e)
        {
            try
            {
                ClassTotal.excelApplication = new Excel.Application();  //Создать объект Excel
                ClassTotal.excelApplication.Visible = false;         //Не отображать приложение Excel
            }
            catch
            {
                MessageBox.Show("Скачай MS Excel");
                //return;
                Close();
            }

        }
    }
}
