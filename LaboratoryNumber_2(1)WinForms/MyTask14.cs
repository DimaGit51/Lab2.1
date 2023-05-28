using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryNumber_2_1_WinForms
{
    public partial class MyTask14 : Form
    {
        public MyTask14()
        {
            InitializeComponent();
        }

        
        private void ButtonAdd2_Click(object sender, EventArgs e)
        {
            int number;
            if ((!int.TryParse(textBoxAdd2.Text, out number)))
            {
                MessageBox.Show("Вы ввели не число!!!");
            }
            else
            {
                listBox2.Items.Add(number);
                textBoxAdd2.Clear();
            }
        }

        private void buttonRemove2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1) listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void buttonList2_Click(object sender, EventArgs e)
        {
            int[] dates = new int[listBox2.Items.Count];
            for (int i = 0; i < listBox2.Items.Count; i++) dates[i] = int.Parse(listBox2.Items[i].ToString());
            DataBank.CreatMassL2(dates);
        }

        private void buttonMyTask_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            DataBank.MergeListsElements(listBox3);

        }
    }
}
