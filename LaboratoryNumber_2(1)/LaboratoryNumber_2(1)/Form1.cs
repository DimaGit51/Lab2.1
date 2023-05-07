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
    public partial class Form1 : Form
    {
        Form2 frm2;
        Form3 frm3;
        Form4 frm4;

        public Form1()
        {
            InitializeComponent();
        }

        public void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
                listBox.Items.Add(number);
                textBoxAdd.Clear();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(listBox.SelectedIndex>-1) listBox.Items.RemoveAt(listBox.SelectedIndex);
        }

        private void созданиеСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] dates = new int[listBox.Items.Count];
            for (int i = 0; i < listBox.Items.Count; i++) dates[i] = int.Parse(listBox.Items[i].ToString());
            DataBank.CreatMass(dates);
            DataBank.Logik = 0;
            DataBank.AddElement1 = "*Cписок*";
            DataBank.AddElement2 = "*Распечатать список в ListBox*";
            //DataBank.AddElement2 = "̶В̶в̶е̶д̶и̶т̶е̶ ̶э̶л̶е̶м̶е̶н̶т̶:̶";
            DataBank.buttonCalculate = true;
            DataBank.logicText = true;
            DataBank.buttonClick = "Список->";
            frm2 = new Form2();
            frm2.Show();
        }

        private void вНачалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.AddElement1 = "*Добавление элемента в начало списка*";
            DataBank.AddElement2 = "Введите элемент:";
            DataBank.Logik = 1;
            DataBank.buttonCalculate = true;
            DataBank.logicText = false;
            DataBank.buttonClick = "Добавить->";
            frm2 = new Form2();
            frm2.Show();
        }

        private void вКонецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.AddElement1 = "*Добавление элемента в конец списка*";
            DataBank.AddElement2 = "Введите элемент:";
            DataBank.Logik = 2;
            DataBank.buttonCalculate = true;
            DataBank.logicText = false;
            DataBank.buttonClick = "Добавить->";
            frm2 = new Form2();
            frm2.Show();
        }

        private void произвольноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.AddElement1 = "*Добавление элемента в Random списка*";
            DataBank.AddElement2 = "Введите элемент:";
            DataBank.Logik = 3;
            DataBank.buttonCalculate = true;
            DataBank.logicText = false;
            DataBank.buttonClick = "Добавить->";
            frm2 = new Form2();
            frm2.Show();
        }

        private void вНачалоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataBank.AddElement1 = "*Удаление элемента в начале списка*";
            DataBank.Logik = 4;
            DataBank.AddElement2 = "̶В̶в̶е̶д̶и̶т̶е̶ ̶э̶л̶е̶м̶е̶н̶т̶:̶";
            DataBank.buttonCalculate = true;
            DataBank.logicText = true;
            DataBank.buttonClick = "Удалить->";
            frm2 = new Form2();
            frm2.Show();
        }

        private void вКонецToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataBank.AddElement1 = "*Удаление элемента в конце списка*";
            DataBank.Logik = 5;
            DataBank.AddElement2 = "̶В̶в̶е̶д̶и̶т̶е̶ ̶э̶л̶е̶м̶е̶н̶т̶:̶";
            DataBank.buttonCalculate = true;
            DataBank.logicText = true;
            DataBank.buttonClick = "Удалить->";
            frm2 = new Form2();
            frm2.Show();
        }

        private void вПроизвольнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.AddElement1 = "*Удаление элемента в Random списка*";
            DataBank.Logik = 6;
            DataBank.AddElement2 = "̶В̶в̶е̶д̶и̶т̶е̶ ̶э̶л̶е̶м̶е̶н̶т̶:̶";
            DataBank.buttonCalculate = true;
            DataBank.logicText = true;
            DataBank.buttonClick = "Удалить->";
            frm2 = new Form2();
            frm2.Show();
        }

        private void обработкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3 = new Form3();
            frm3.Show();
        }

        private void разрушениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.AddElement1 = "*Разрушение списка*";
            DataBank.Logik = 7;
            DataBank.AddElement2 = "̶В̶в̶е̶д̶и̶т̶е̶ ̶э̶л̶е̶м̶е̶н̶т̶:̶";
            DataBank.buttonCalculate = true;
            DataBank.logicText = true;
            DataBank.buttonClick = "Разрушить->";
            frm2 = new Form2();
            frm2.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm4 = new Form4();
            frm4.Show();
        }


    }
}
