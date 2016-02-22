using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Diploma_NevskiiProekt
{
    public partial class DocForm : Form
    {
        MainForm main = new MainForm();
        private MainMenu menu;
        ToolTip message = new ToolTip();
        public DocForm()
        {
            InitializeComponent();
            //panel1.Hide();
            //panel2.Hide();
            this.AutoScroll = true;
            menu = new MainMenu(); //создание 
            MenuItem mFile = menu.MenuItems.Add("Окно");
            mFile.MenuItems.Add(new MenuItem("Выйти",
               new EventHandler(this.fileExit_Click), Shortcut.CtrlX));
            mFile.MenuItems.Add(new MenuItem("Сохранить",
                new EventHandler(this.fileSave_Click), Shortcut.CtrlS));
            mFile.MenuItems.Add(new MenuItem("Главное меню",
                new EventHandler(this.fileMainMenu_Click), Shortcut.CtrlM));
            this.Menu = menu;
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            this.Close();		// Выход из приложения
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
            //this.Close();		// Сохранение в документ
        }

        private void fileMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            this.main = main;
            main.Show();
        }

        private void personalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diploma_NevskiiProectDataSet);

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.diploma_NevskiiProectDataSet.Personal);

        }

        private void toolStripMainButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.main = main;
            main.Show();
            this.Hide();
        }

        private void dljaZapolnenijaOsnovanijePrikazaOPriemeTextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaOsnovanijePrikazaOPriemeTextBox, "напр., “Трудовой договор от 14 мая 2015 №12-ТД”");

    }

        private void dljaZapolnenijaZajavlenijaFIOLine1TextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(textBox1, "напр., “Иванова”...");
        }

        private void dljaZapolnenijaZajavlenijaFIOLine2TextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaZajavlenijaFIOLine2TextBox, "напр., …”Ивана Ивановича”");
        }

        private void dljaZapolnenijaDogMOAdresLine2TextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaDogMOAdresLine2TextBox, "для заполнения договора о мат. отв-ти; напр., …”ул. Таврическая, д. 6, кв. 5”");
        }

        private void dljaZapolnenijaDogMOAdresLine1TextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaDogMOAdresLine1TextBox, "для заполнения договора о мат. отв-ти; напр., ”г.Санкт-Петербург, ”...");
        }

        private void dljaZapolnenijaLKAdresFakticheskiiLine2TextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaLKAdresFakticheskiiLine2TextBox, "для заполнения личной карточки; напр., …”ул. Таврическая, д. 6, кв. 5”");
        }

        private void dljaZapolnenijaLKAdresFakticheskiiLine1TextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaLKAdresFakticheskiiLine1TextBox, "для заполнения личной карточки; напр., ”г.Санкт-Петербург, ”...");
        }

        private void dljaZapolnenijaLKAdresPoPropiskeLine2TextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaLKAdresPoPropiskeLine2TextBox, "для заполнения личной карточки; напр., …”ул. Таврическая, д. 6, кв. 5”");
        }

        private void dljaZapolnenijaLKAdresPoPropiskeLine1TextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaLKAdresPoPropiskeLine1TextBox, "для заполнения личной карточки; напр., ”г.Санкт-Петербург, ”...");
        }

        private void dljaZapolnenijaLKPasportVidanLine2TextBox_TextChanged(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaLKPasportVidanLine2TextBox, "для заполнения личной карточки; напр., …”и Ленинградской области”");
        }

        private void dljaZapolnenijaLKPasportVidanLine1TextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaLKPasportVidanLine1TextBox, "для заполнения личной карточки; напр., “ГУВД Санкт-Петербурга ”...");
        }

        private void dljaZapolnenijaIOFamilijaTextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaIOFamilijaTextBox, "напр., “И.И.Иванов");
        }

        private void dljaZapolnenijaFamilijaIOTextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaFamilijaIOTextBox, "напр., “напр., “Иванов И.И.");
        }

        private void DocForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

}}
