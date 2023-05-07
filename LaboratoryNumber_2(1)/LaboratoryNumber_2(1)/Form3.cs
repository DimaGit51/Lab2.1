using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryNumber_2_1_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            int number;
            if ((!int.TryParse(textBoxAdd.Text, out number)))
            {
                MessageBox.Show("Вы ввели не число!!!");
            }
            else
            {
                listBox1.Items.Add(number);
                textBoxAdd.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if ((!int.TryParse(textBox1.Text, out number)))
            {
                MessageBox.Show("Вы ввели не число!!!");
            }
            else
            {
                listBox2.Items.Add(number);
                textBox1.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1) listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1) listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] dates = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++) dates[i] = int.Parse(listBox1.Items[i].ToString());
            DataBank.CreatMassZ1(dates);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] dates = new int[listBox2.Items.Count];
            for (int i = 0; i < listBox2.Items.Count; i++) dates[i] = int.Parse(listBox2.Items[i].ToString());
            DataBank.CreatMassZ2(dates);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            DataBank.MergeListsElements(listBox3);
        }
    }
}
