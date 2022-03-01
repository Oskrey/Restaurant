using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace Ресторан
{
    public partial class FormAutorization : Form
    {
        string Passwd = File.ReadAllText("passwd.txt");

        bool vis = true;
        int i = 0;
        int sch = 0;

        public FormAutorization()
        {
            InitializeComponent();
        }

        private void buttonLook_Click(object sender, EventArgs e)
        {
            if (vis)
            {
                textBoxPasswd.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {
                textBoxPasswd.UseSystemPasswordChar = true;
                vis = true;
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string Pass = textBoxPasswd.Text;

            if (textBoxPasswd.Text == "")
            {
                MessageBox.Show("Введите пожалуйста пароль", "Ошибка авторизации");
            }

            else if (Pass == Passwd)
            {
                FormManageMenu form_managemenu = new FormManageMenu();
                form_managemenu.Show();
                textBoxPasswd.Clear();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный пароль", "Ошибка авторизации");
                i++;
                while (i < 4)
                {
                    int o = 3 - i;
                    if (o == 0)
                        Application.Exit();
                    else
                    {
                        MessageBox.Show("Количество попыток: " + o);
                        textBoxPasswd.Clear();
                    }
                    sch = i;

                    return;
                }
            }
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            DialogResult ress;
            ress = MessageBox.Show("Вы действительно хотите сменить пароль?", "Смена пароля", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ress == DialogResult.Yes)
            {
                string replog11, replog22;
                replog11 = Interaction.InputBox("Введите новый пароль");
                replog22 = Interaction.InputBox("Повторите новый пароль");
                if (replog11 == replog22)
                {
                    File.WriteAllText("passwd.txt", Convert.ToString(replog11));
                    MessageBox.Show("Пароль успешно изменен");
                    Passwd = File.ReadAllText("passwd.txt");
                }
                else
                {
                    MessageBox.Show("Попробуйте еще раз");
                }
            }
        }
    }
}
