using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Ресторан
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
       
    }
    public class ClassTotal
    {
        public static Excel.Application excelApplication;   //Сервер Excel
        public static Excel.Workbook excelBook; //Отдельная книга
        public static Excel.Worksheet excelSheet;   //Один лист
        public static Excel.Range excelCells;   //Ячейки
    }
    public class Start
    {
        public static void startExel()
        {
            try
            {
                ClassTotal.excelApplication.Visible = false;

                string path = Application.StartupPath;
                string fileName = path + @"\PriceList.xlsx"; // Абсолютный путь к файлу
                if (File.Exists(fileName)) // Проверка существует ли  файл
                {
                    // Открытие книги Excel
                    ClassTotal.excelBook = ClassTotal.excelApplication.Workbooks.Open(fileName);
                }
                else
                {
                    MessageBox.Show("Прайс-лист отсутствует");
                }

            }
            catch
            {
                MessageBox.Show("Невозможно запустить Excel");
            }

        }

    }

}
