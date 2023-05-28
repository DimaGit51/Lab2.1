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
    public partial class PatternDelInList_Random : Form
    {
        public PatternDelInList_Random()
        {
            InitializeComponent();
            DataBank.PrintListBox(listBox_PrintListDelRandom);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if ((!int.TryParse(textBoxFindElementDR.Text, out number))) MessageBox.Show("Вы ввели не число!!!");
            else textBoxFindElementDR.Clear();


            DataBank.DelElementsR(number);
            listBox_PrintListDelRandom.Items.Clear();
            DataBank.PrintListBox(listBox_PrintListDelRandom);
        }
    }
}
