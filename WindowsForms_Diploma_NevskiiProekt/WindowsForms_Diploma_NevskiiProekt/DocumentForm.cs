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
    public partial class DocumentForm : Form
    {
        MainForm main = new MainForm();
        private MainMenu menu;
        ToolTip message = new ToolTip();
        public DocumentForm()
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nalichieSoglasijaNaNochCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
        // Изменние свойства Visible у двух панелей (наличие документов и заполнение формы)
        private int btnCount = 0; 
        //private int stop = 0;
        private void formButton_Click(object sender, EventArgs e)
        {
            btnCount++;
            int i;
            for (i = 0; i <= 2; i++) { 
                if (btnCount == 1) { formPanel.Visible = true;
                this.Width = 1049; this.Height = 1020;
                }
                if (btnCount == 2) { formPanel.Visible = false;

                    this.Width = 1049; this.Height = 800; btnCount = 0;
                }
            }
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMainButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.main = main;
            main.Show();
            this.Hide();
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void innTextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(innTextBox, "12 символов");
        }

        private void innTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            innTextBox.MaxLength = 12;
        }

        private void snilsTextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(snilsTextBox, "11 символов");
        }

        private void snilsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            snilsTextBox.MaxLength = 11;
        }
        
        private void label2_MouseHover(object sender, EventArgs e)
        {
            message.SetToolTip(label2, "Для распечатывания документа с заполненными данными выберите в списке справа вместо “пустой документ” фамилию сотрудника");
        }

        private void nalichieTrudovojKnijkiCheckBox_MouseHover(object sender, EventArgs e)
        {
            message.SetToolTip(nalichieTrudovojKnijkiCheckBox, "Не обязательно для работы по совместительству");

        }
    }
}
