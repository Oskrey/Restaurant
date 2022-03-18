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
using System.Windows.Forms.DataVisualization.Charting;

namespace Ресторан
{
    public partial class FormOrder : Form
    {

        double summaWallet = Money.Value;//Сумма в кошельке
        double summaOrder;		//Сумма заказа
        double summaBalance;	//Сумма остатка

        List<ClassDish> listDishes;	//Список информации о выбранных блюдах
        public FormOrder()
        {
            InitializeComponent();
        }

        private void buttonIssueOrder_Click(object sender, EventArgs e)
        {
            FormCheck form_check = new FormCheck();
            Hide();
            form_check.ShowDialog();
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            Close();
            ClassTotal.excelApplication.Quit();      //Выйти из Excel
                                                     //Уничтожить все COM-объекты
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(ClassTotal.excelApplication);
            //Заставляет сборщик мусора провести сборку мусора
            GC.Collect();
            Form open = Application.OpenForms["FormMain"];


            open.Show();
        }




        private void FormOrder_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            // Форматировать диаграмму
            chart1.BackColor = Color.Gray;
            chart1.BackSecondaryColor = Color.Transparent;
            chart1.BackGradientStyle = GradientStyle.DiagonalRight;

            chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            chart1.BorderlineColor = Color.Gray;
            chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            // Форматировать область диаграммы
            chart1.ChartAreas[0].BackColor = Color.Wheat;
            chart1.Legends.Clear();

            chart1.Series.Add(new Series("ColumnSeries")
            {
                ChartType = SeriesChartType.Pie
            });

            // Salary series data
            double[] yValues = { summaWallet, 0 };
            string[] xValues = { "Осталось", "Потрачено" };
            chart1.Series["ColumnSeries"].Points.DataBindXY(xValues, yValues);

            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

            ClassTotal.excelSheet = (Excel.Worksheet)ClassTotal.excelBook.Worksheets.get_Item("Категории");
            ClassTotal.excelSheet = (Excel.Worksheet)ClassTotal.excelBook.Sheets.get_Item("Категории");
            ClassTotal.excelSheet = (Excel.Worksheet)ClassTotal.excelBook.Worksheets["Категории"];
            ClassTotal.excelSheet = (Excel.Worksheet)ClassTotal.excelBook.Sheets[1];

            //Получит все заполненные ячейки
            ClassTotal.excelCells = ClassTotal.excelSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            //Количество=номеру последней заполненной ячейки
            int count = ClassTotal.excelCells.Row;
            //Перенос в список
            listDishes = new List<ClassDish>();

            listBoxCat.Items.Clear();
            for (int i = 1; i <= count; i++)
            {
                ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 1];  //Ссылка на нужную ячейку
                if (ClassTotal.excelCells != null)
                {
                    listBoxCat.Items.Add(ClassTotal.excelCells.Value2);  //Значение этой ячейки
                }
            }

            ShowOrder();
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
            listViewMenu.Items.Clear();        //Сначала список надо очистить
            listViewMenu.LabelWrap = true;    //Запретить перенос на новую строку
            listViewMenu.MultiSelect = true;   //Разрешить выделять несколько
            listViewMenu.FullRowSelect = true;
            listViewMenu.RightToLeftLayout = false;
            listViewMenu.Scrollable = true;    //Обеспечить наличие полос прокрутки
            listViewMenu.View = View.LargeIcon;    //Вид компонента – большие картинки
                                                     //Создание списка картинок
            ImageList imageList = new ImageList();     //Динамический элемент – массив изображений
            imageList.ImageSize = new Size(250, 250);  //Размеры всех изображений одинаковы
            listViewMenu.LargeImageList = imageList;  //Связать два списка между собой
            imageList.Images.Clear();              //Очистить список картинок
            string nameFood;                //Название блюда
            double weighFood;
            double caloriesFood;
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
                weighFood = ClassTotal.excelCells.Value2;

                ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 4];
                caloriesFood = ClassTotal.excelCells.Value2;



                ListViewItem listViewItem = new ListViewItem();      //Элемент списка
                listViewItem.Text = nameFood + " | " + weighFood.ToString() + " грамм, " 
                    + caloriesFood.ToString() + " каллорий, цена (₽) — " + costFood.ToString();// + "₽";  //Текст элемента
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
                imageList.Images.Add(bitmap);      //Добавить картинку в массив картинок
                listViewItem.ImageIndex = (i - 2);       //Для элемента списка задать индекс картинки
                listViewMenu.Items.Add(listViewItem);        // добавляем элемент в ListView
            }
        }
        private void ShowOrder()
        {
            //Отображать список с учетом списка из информации о блюдах
            listBoxDishes.Items.Clear();
            summaOrder = 0;
            //Просмотр списка информации о блюдах
            foreach (var itemList in listDishes)
            {
                //Вывести название и цену
                listBoxDishes.Items.Add(itemList.Title + " — " + itemList.Count + " шт."  + " всего: " + itemList.Price*itemList.Count+ " ₽");
                //Учет в стоимости заказа выбранного блюда и его количества
                summaOrder += (itemList.Price * itemList.Count);
            }
            summaBalance = summaWallet - summaOrder;	//Расчет остатка
            //Отображение
            labelCalc.Text = "Было в кошельке = " + summaWallet + Environment.NewLine +
                "Сумма заказа = " + summaOrder + Environment.NewLine +
                "Осталось средств = " + summaBalance;

            double[] yValues = { summaBalance, summaOrder };
            string[] xValues = { "Осталось", "Потрачено" };
            chart1.Series["ColumnSeries"].Points.DataBindXY(xValues, yValues);
        }
        private void FormOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void buttonGoToOrder_Click(object sender, EventArgs e)
        {
            string titleDish = "";
            ClassDish dish;
            string temp;
            bool search = false;
            double summaSelect = 0;
            //Проверка наличия выбранных блюд
            int countSelect = this.listViewMenu.SelectedItems.Count;
            if (countSelect == 0)
            {
                MessageBox.Show("Вы не выбрали ни одно блюдо");
                return;
            }
            //Расчет стоимости выбранных блюд
            foreach (ListViewItem item in this.listViewMenu.SelectedItems)
            {
                summaSelect += double.Parse(item.Text.Split('—')[1]);
            }
            //Проверка достаточного количества денег на выбранные блюда
            if (summaSelect > summaBalance)
            {
                MessageBox.Show("У Вас не хватает денег на этот заказ");
                return;
            }

            //Перенос выбранных блюд в заказ
            foreach (ListViewItem item in this.listViewMenu.SelectedItems)
            {
                temp = item.Text;
                search = false;
                titleDish = temp.Split('|')[0]; 		//Название
                //Поиск выбранного блюда среди заказанных
                foreach (var itemList in listDishes)	//Просмотр всех заказанных блюд
                {
                    if (titleDish == itemList.Title)		//Такое уже выбирали
                    {
                        itemList.Count++;			//Увеличиваем количество этого блюда
                        search = true;
                        break;
                    }
                }
                if (!search)		//Если это блюдо выбрали первый раз, то добавляем его список
                {
                    dish = new ClassDish();		//Создать объект с информацией о блюде
                    dish.Title = titleDish;
                    dish.Price = double.Parse(temp.Split('—')[1]);
                    dish.Count = 1;				//Первый раз
                    listDishes.Add(dish);			//Добавить новый объект в список
                }
            }
            ShowOrder();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
        }

        private void listBoxDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDishes.ClearSelected();

        }
    }
}

