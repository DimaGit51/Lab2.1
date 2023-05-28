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
    public partial class PatternAddInList_Random : Form
    {
        public PatternAddInList_Random()
        {
            InitializeComponent();
            DataBank.PrintListBox(listBox_PrintList);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if ((!int.TryParse(textBoxFindElement.Text, out number))) MessageBox.Show("Вы ввели не число!!!");
            else textBoxFindElement.Clear();
       
            int number1;
            if (!int.TryParse(textBoxAddElementRandom.Text, out number1)) MessageBox.Show("Вы ввели не число!!!");
            
            DataBank.AddElementesR(number, number1);
            listBox_PrintList.Items.Clear();
            DataBank.PrintListBox(listBox_PrintList);

        }
    }
}
