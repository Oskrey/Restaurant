using System;
using System.Collections.Generic;
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
        public class ClassTotal
        {
            public static Excel.Application excelApplication;   //Сервер Excel
            public static Excel.Workbook excelBook; //Отдельная книга
            public static Excel.Worksheet excelSheet;   //Один лист
            public static Excel.Range excelCells;   //Ячейки
        }

    }


}
