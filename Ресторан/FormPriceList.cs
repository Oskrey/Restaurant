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

            //Добавление категорий с первого листа
            int countSheet = ClassTotal.excelBook.Worksheets.Count;
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
            listBoxCat.SelectedIndex = 1;
            //Заполнение меню
            string category = listBoxCat.SelectedItem.ToString();    //Выбранная категория
                                                                            //Связаться с нужным листом-категорией блюд
            ClassTotal.excelSheet =(Excel.Worksheet)ClassTotal.excelBook.Worksheets.get_Item(category);
            //Ссылка на заполненные ячеки в листе
            ClassTotal.excelCells =
                           ClassTotal.excelSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            //Номер последней заполненной строки – это число строк (названий блюд)
            int countFood = ClassTotal.excelCells.Row;
            //Настройки ListView для отображения картинок блюд
            listViewPriceList.Items.Clear();        //Сначала список надо очистить
            listViewPriceList.CheckBoxes = true;    //Разрешить флажки возле картинок
            listViewPriceList.LabelWrap = false;    //Запретить перенос на новую строку
            listViewPriceList.MultiSelect = true;   //Разрешить выделять несколько
            listViewPriceList.FullRowSelect = true;
            listViewPriceList.RightToLeftLayout = false;
            listViewPriceList.Scrollable = true;    //Обеспечить наличие полос прокрутки
            listViewPriceList.View = View.LargeIcon;    //Вид компонента – большие картинки
                                                        //Создание списка картинок
            ImageList il = new ImageList();     //Динамический элемент – массив изображений
            il.ImageSize = new Size(100, 100);  //Размеры всех изображений одинаковы
            listViewPriceList.LargeImageList = il;  //Связать два списка между собой
            il.Images.Clear();              //Очистить список картинок
            string nameFood;                //Название блюда
            double costFood;                //Цена блюда
            string fileFoodPic;                //Файл картинки
            Bitmap bitmap;
            for (int i = 1; i <= countFood; i++)        //По всем блюдам
            {
                ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 1];      //Ссылка на ячейку
                nameFood = ClassTotal.excelCells.Value2;        //Название блюда
                ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 2];      //Ссылка на ячейку
                costFood = ClassTotal.excelCells.Value2;        //Цена блюда
                ListViewItem lvi = new ListViewItem();      //Элемент списка
                lvi.Text = nameFood + " - " + costFood.ToString();  //Текст элемента
                                                                    //Абсолютный путь к файлу с изображением блюда
                fileFoodPic = Application.StartupPath + @"\" + category + @"\" + nameFood + ".jpg";
                if (File.Exists(fileFoodPic))				//Проверка существования картинки
                {
                    bitmap = new Bitmap(fileFoodPic);		//Есть – загрузить
                }
                else
                {
                    bitmap = Properties.Resources.Кнопка;		//Нет – из ресурсов
                }
                il.Images.Add(bitmap);      //Добавить картинку в массив картинок
                lvi.ImageIndex = (i - 1);       //Для элемента списка задать индекс картинки
                listBoxCat.Items.Add(lvi);        // добавляем элемент в ListView
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
