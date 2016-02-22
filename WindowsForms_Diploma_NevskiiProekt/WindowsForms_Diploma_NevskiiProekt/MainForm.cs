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
    public partial class MainForm : Form
    {
        //AddForm add = new AddForm();
        public MainForm()
        {
            InitializeComponent();
        }

        //(Вера) Кнопка открывает форму приема на работу и добавления информации
        private void button3_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            //this.add = add;
            add.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FireForm fire = new FireForm();
            fire.Show();
            this.Hide();
        }
        // Переход к форме заполнения
        private void button2_Click(object sender, EventArgs e)
        {
            FireForm_ newForm = new FireForm_();
            newForm.Show();
            this.Hide();
        }
        //Закрытие приложения
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toInformationButton_MouseHover(object sender, EventArgs e)
        {

            toInformationButton.BackColor = Color.FromName("ActiveCaption");
        }

        private void toInformationButton_MouseLeave(object sender, EventArgs e)
        {
            toInformationButton.BackColor = Color.FromName("Control");
        }

        private void toEditFormButton_MouseHover(object sender, EventArgs e)
        {
            toEditFormButton.BackColor = Color.FromName("ActiveCaption");
        }

        private void toEditFormButton_MouseLeave(object sender, EventArgs e)
        {
            toEditFormButton.BackColor = Color.FromName("Control");
        }

        private void toAddFormButton_MouseHover(object sender, EventArgs e)
        {
            toAddFormButton.BackColor = Color.FromName("ActiveCaption");
        }

        private void toAddFormButton_MouseLeave(object sender, EventArgs e)
        {
            toAddFormButton.BackColor = Color.FromName("Control");
        }

        private void toFireFormButton_MouseHover(object sender, EventArgs e)
        {
            toFireFormButton.BackColor = Color.FromName("ActiveCaption");
        }

        private void toFireFormButton_MouseLeave(object sender, EventArgs e)
        {
            toFireFormButton.BackColor = Color.FromName("Control");
        }

        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromName("ActiveCaption");
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromName("Control");
        }


    }
}
