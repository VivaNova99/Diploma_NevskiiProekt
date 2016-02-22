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
    public partial class FireForm : Form
    {
        MainForm main = new MainForm();
        DocForm doc = new DocForm();
        private MainMenu menu;
        ToolTip message = new ToolTip();

        public FireForm()
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
            if (MessageBox.Show("Вы уверены, что хотите выйти? Несохраненные данные будут утеряны.", Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.StatusInOrganization". При необходимости она может быть перемещена или удалена.
            this.statusInOrganizationTableAdapter.Fill(this.diploma_NevskiiProectDataSet.StatusInOrganization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.DismissalReason". При необходимости она может быть перемещена или удалена.
            this.dismissalReasonTableAdapter.Fill(this.diploma_NevskiiProectDataSet.DismissalReason);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diploma_NevskiiProectDataSet.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.diploma_NevskiiProectDataSet.Personal);

        }

        // Изменние свойства Visible у двух панелей (наличие документов и заполнение формы)
        private int btnCount = 0;
        private int btnCount2 = 0;
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

                    this.Width = 1049; this.Height = 850; btnCount = 0;
                }
            }
        }        
        
        private void docButton_Click(object sender, EventArgs e)
        {
            btnCount2++;
            int i;
            for (i = 0; i <= 2; i++)
            {
                if (btnCount2 == 1)
                {
                    docPanel.Visible = true;
                    this.Width = 1049; this.Height = 1020;
                }
                if (btnCount2 == 2)
                {
                    docPanel.Visible = false;
                    this.Width = 1049; this.Height = 850; btnCount2 = 0;
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
                
        private void nalichieZajavlObUvolneniiCheckBox_MouseHover(object sender, EventArgs e)
        {
            message.SetToolTip(nalichieZajavlObUvolneniiCheckBox, "при увольнении по собственному желанию");
        }        
        
        private void dataUvolnenijaDateTimePicker_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dataUvolnenijaDateTimePicker, "последний день работы");
        }

        private void dljaZapolnenijaOsnovanijePrikazaObUvolnTextBox_Enter(object sender, EventArgs e)
        {
            message.SetToolTip(dljaZapolnenijaOsnovanijePrikazaObUvolnTextBox, "напр., “заявление от 20.07.14”");
        }

     
        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Вы уверены, что хотите выйти? Несохраненные данные будут утеряны.", Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        this.Close();
            //    } 
        }


        private void FireForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FireForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
