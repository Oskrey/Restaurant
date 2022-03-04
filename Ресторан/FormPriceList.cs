using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ресторан.Program;
using Excel = Microsoft.Office.Interop.Excel;

namespace Ресторан
{
 

    public partial class FormPriceList : Form
    {
        /*public class ClassTotal
        {
            public static Excel.Application excelApp;   //Сервер Excel
            public static Excel.Workbook excelBook; //Отдельная книга
            public static Excel.Worksheet excelSheet;   //Один лист
            public static Excel.Range excelCells;   //Ячейки
        }
        */
        public FormPriceList()
        {
            InitializeComponent();
        }

        private void FormPriceList_Load(object sender, EventArgs e)
        {
//Запукс Excel
            try
            {
                ClassTotal.excelApplication = new Excel.Application();  //Создать объект Excel
               //ClassTotal.excelApplication.Visible = false;         //Не отображать приложение Excel
            }
            catch
            {
                MessageBox.Show("Скачай MS Excel");
                this.Close();
            }
//Открытие документа 
            string path = Application.StartupPath;      //Путь к exe-файлу приложения
            string fileName = path + @"\PriceList.xlsx"; //Абсолютный путь к файлу Excel
            if (File.Exists(fileName))          //Проверить наличие документа
            {
                //Открыть книгу Excel
                ClassTotal.excelBook = ClassTotal.excelApplication.Workbooks.Open(fileName);
                MessageBox.Show("Файл с меню Есть");
            }
            else
            {
                MessageBox.Show("Файл с меню отсутствует");
                this.Close();
            }
            int countSheet = ClassTotal.excelBook.Worksheets.Count;
            string sheetName = "";
            foreach (Excel.Worksheet item in ClassTotal.excelBook.Worksheets)
            {
                sheetName += item.Name + Environment.NewLine;
            }
            MessageBox.Show(sheetName);
            ClassTotal.excelSheet = ClassTotal.excelBook.Sheets[1];
            ClassTotal.excelCells = ClassTotal.excelSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            //Количество=номеру последней заполненной ячейки
            int count = ClassTotal.excelCells.Row;
            //Перенос в список
            listBoxCat.Items.Clear();
            for (int i = 1; i <= count; i++)
            {
                ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 1];  //Ссылка на нужную ячейку
                if (ClassTotal.excelCells != null)
                {
                    listBoxCat.Items.Add(ClassTotal.excelCells.Value2);  //Значение этой ячейки
                }
            }


        }
        private void FormPriceList_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassTotal.excelApplication.Quit();      //Выйти из Excel
                                             //Уничтожить все COM-объекты
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(ClassTotal.excelApplication);
            //Заставляет сборщик мусора провести сборку мусора
            GC.Collect();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
