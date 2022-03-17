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
using System.IO;

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

            Start.startExel();

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

        private void listBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            string category = listBoxCat.SelectedItem.ToString();    //Выбранная категория
                                                                   //Связаться с нужным листом-категорией блюд
            ClassTotal.excelSheet = (Excel.Worksheet)ClassTotal.excelBook.Worksheets.get_Item(category);
            //Ссылка на заполненные ячеки в листе
            ClassTotal.excelCells = ClassTotal.excelSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            //Номер последней заполненной строки – это число строк (названий блюд)
            int countFood = ClassTotal.excelCells.Row;
            //Настройки ListView для отображения картинок блюд
            this.listView1.Items.Clear();        //Сначала список надо очистить
            this.listView1.CheckBoxes = true;    //Разрешить флажки возле картинок
            this.listView1.LabelWrap = false;    //Запретить перенос на новую строку
            this.listView1.MultiSelect = true;   //Разрешить выделять несколько
            this.listView1.FullRowSelect = true;
            this.listView1.RightToLeftLayout = false;
            this.listView1.Scrollable = true;    //Обеспечить наличие полос прокрутки
            this.listView1.View = View.LargeIcon;    //Вид компонента – большие картинки
                                                     //Создание списка картинок
            ImageList il = new ImageList();     //Динамический элемент – массив изображений
            il.ImageSize = new Size(250, 250);  //Размеры всех изображений одинаковы
            this.listView1.LargeImageList = il;  //Связать два списка между собой
            il.Images.Clear();              //Очистить список картинок
            string nameFood;                //Название блюда
            string cat1;
            string cat2;
            double costFood;                //Цена блюда
            string fileFood;                //Файл картинки
            Bitmap bitmap;

            for (int i = 2; i <= countFood; i++)        //По всем блюдам
            {
                ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 1];      //Ссылка на ячейку
                nameFood = ClassTotal.excelCells.Value2;        //Название блюда

                ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 2];      //Ссылка на ячейку
                costFood = ClassTotal.excelCells.Value2;        //Цена блюда

                ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 3];
                cat1 = ClassTotal.excelCells.Value2;

                ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 4];
                cat2 = ClassTotal.excelCells.Value2;



                ListViewItem lvi = new ListViewItem();      //Элемент списка
                lvi.Text = nameFood + " | " + cat1 + " | \n" + cat2 + " - " + costFood.ToString() + "₽";  //Текст элемента
                                                                                                          //Абсолютный путь к файлу с изображением блюда
                fileFood = path + @"\" + category + @"\" + nameFood + ".jpg";
                if (File.Exists(fileFood))				//Проверка существования картинки
                {
                    bitmap = new Bitmap(fileFood);		//Есть – загрузить
                }
                else
                {
                    bitmap = Properties.Resources.NotImage;		//Нет – из ресурсов
                }
                il.Images.Add(bitmap);      //Добавить картинку в массив картинок
                lvi.ImageIndex = (i - 2);       //Для элемента списка задать индекс картинки
                listView1.Items.Add(lvi);        // добавляем элемент в ListView
            }
        }
    }
}
