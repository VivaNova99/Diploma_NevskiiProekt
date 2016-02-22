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
    public partial class AddForm : Form
    {
        MainForm main = new MainForm();
        DocForm doc = new DocForm();
        private MainMenu menu;
        ToolTip message = new ToolTip();

        public AddForm()
        {

            InitializeComponent();
            //panel1.Hide();
            //panel2.Hide();
            this.AutoScroll = true;
            menu = new MainMenu(); //
            MenuItem mFile = menu.MenuItems.Add("Окно");
            mFile.MenuItems.Add(new MenuItem("Выйти",
               new EventHandler(this.fileExit_Click), Shortcut.CtrlX));
            mFile.MenuItems.Add(new MenuItem("Сохранить",
                new EventHandler(this.fileSave_Click), Shortcut.CtrlS));
            mFile.MenuItems.Add(new MenuItem("Главное меню",
                new EventHandler(this.fileMainMenu_Click), Shortcut.CtrlM));
            this.Menu = menu;
        }

        private void fileExit_Click(object sender, EventArgs e) // Выход из приложения 
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти? Несохраненные данные будут утеряны.", 
                Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
        // Сохранение в документ
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.CharacterOfWork". При необходимости она может быть перемещена или удалена.
            this.characterOfWorkTableAdapter.Fill(this.diploma_NevskiiProectDataSet.CharacterOfWork);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.ManningTable". При необходимости она может быть перемещена или удалена.
            this.manningTableTableAdapter.Fill(this.diploma_NevskiiProectDataSet.ManningTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.Languages". При необходимости она может быть перемещена или удалена.
            this.languagesTableAdapter.Fill(this.diploma_NevskiiProectDataSet.Languages);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.StatusInOrganization". При необходимости она может быть перемещена или удалена.
            this.statusInOrganizationTableAdapter.Fill(this.diploma_NevskiiProectDataSet.StatusInOrganization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.KodiOkinGrazhdanstvo". При необходимости она может быть перемещена или удалена.
            this.kodiOkinGrazhdanstvoTableAdapter.Fill(this.diploma_NevskiiProectDataSet.KodiOkinGrazhdanstvo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.KodiOkinObrazovanije". При необходимости она может быть перемещена или удалена.
            this.kodiOkinObrazovanijeTableAdapter.Fill(this.diploma_NevskiiProectDataSet.KodiOkinObrazovanije);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.Sex". При необходимости она может быть перемещена или удалена.
            this.sexTableAdapter.Fill(this.diploma_NevskiiProectDataSet.Sex);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.KindOfWork". При необходимости она может быть перемещена или удалена.
            this.kindOfWorkTableAdapter.Fill(this.diploma_NevskiiProectDataSet.KindOfWork);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.diploma_NevskiiProectDataSet.Personal);

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

        //Кнопка перехода к главному меню
        private void toolStripMainButton_Click(object sender, EventArgs e)
        {
            //MainForm main = new MainForm();
            //this.main = main;
            main.Show();
            this.Hide();
        }

   

        //Ограничение на ввод
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
        
        private void okladCiframiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }
        private void tabNomerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }
        //Всплывающие подсказки

        private void label2_MouseHover(object sender, EventArgs e)
        {
            message.SetToolTip(label2, "Для распечатывания документа с заполненными данными выберите в списке справа вместо “пустой документ” фамилию сотрудника");
        }

        private void nalichieTrudovojKnijkiCheckBox_MouseHover(object sender, EventArgs e)
        {
            message.SetToolTip(nalichieTrudovojKnijkiCheckBox, "Не обязательно для работы по совместительству");

        }

        private void nalichieZajavlNaVidachuTrudovojCheckBox_MouseHover(object sender, EventArgs e)
        {
            message.SetToolTip(nalichieZajavlNaVidachuTrudovojCheckBox, "для поступающих на работу впервые");
        }

        private void nalichieSanKnizhkiCheckBox_MouseHover(object sender, EventArgs e)
        {
            message.SetToolTip(nalichieSanKnizhkiCheckBox, "для определенных должностей");
        }

        private void nalichieZajavlNaPolstavkiCheckBox_MouseHover(object sender, EventArgs e)
        {
            message.SetToolTip(nalichieZajavlNaPolstavkiCheckBox, "если нужно его наличие; для работы по совместительству не нужно");
        }

        private void dataNachalaRabotiDateTimePicker_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dataNachalaRabotiDateTimePicker, "в соответствии с трудовым договором");
        }

        private void okladCiframiTextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(okladCiframiTextBox, "напр., “10000”");
        }

        private void nomerTDTextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(nomerTDTextBox, "предпочтительно табельный номер + буквы ТД");
        }

        private void dataTDDateTimePicker_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dataTDDateTimePicker, "дата подписания <= дата начала работы");
        }

        private void dataPrikazaOPriemeDateTimePicker_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dataPrikazaOPriemeDateTimePicker, "дата подписания труд. договора <= дата издания приказа <= дата начала работы");
        }

        private void okonchanijeTDDateTimePicker_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(okonchanijeTDDateTimePicker, "для срочных трудовых договоров; срок не может быть больше 5 лет");
        }

        private void ispitSrokTextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(ispitSrokTextBox, "в месяцах, прописью (напр., “три”)");
        }        
        
        private void toDocFormButton_Click(object sender, EventArgs e)
        {    
            if (MessageBox.Show("Вы уверены, что хотите выйти? Несохраненные данные будут утеряны.", 
                Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {doc.Show();
                this.Hide();}
        }       
        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Вы уверены, что хотите выйти? Несохраненные данные будут утеряны.", Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        this.Close();
            //    } 
        }
        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



    }
}
