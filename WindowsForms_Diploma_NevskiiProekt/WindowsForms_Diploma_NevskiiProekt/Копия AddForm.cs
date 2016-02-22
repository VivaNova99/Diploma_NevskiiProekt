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
        public AddForm()
        {
            InitializeComponent();
            //panel1.Hide();
            //panel2.Hide();
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

        private int btnCount = 0; 
        //private int stop = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            btnCount++;
            int i;
            for (i = 0; i <= 2; i++) { 
                if (btnCount == 1) { panel1.Visible = true; }
                if (btnCount == 2) { panel1.Visible = false; btnCount = 0;}
            }
        }
        private int btnCount2 = 0;
        private void button28_Click(object sender, EventArgs e)
        {
            btnCount2++;
            int i;
            for (i = 0; i <= 2; i++)
            {
                if (btnCount2 == 1) { panel2.Visible = true; }
                if (btnCount2 == 2) { panel2.Visible = false; btnCount2 = 0; }
            }
        }
    }
}
