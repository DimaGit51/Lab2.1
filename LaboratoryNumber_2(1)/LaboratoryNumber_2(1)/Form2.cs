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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            buttonCalculate.Text = DataBank.buttonClick;
            labelInfo2.Text += DataBank.AddElement1;
            labelInfo3.Text += DataBank.AddElement2;
            if(!DataBank.logicText) textBoxElement.ReadOnly = false;
            else textBoxElement.ReadOnly = true;
            if (!DataBank.buttonCalculate) buttonCalculate.Enabled = false;
            else buttonCalculate.Enabled = true;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            listBoxCalculate.Items.Clear();
            int number;
            if ((!int.TryParse(textBoxElement.Text, out number)) && !DataBank.logicText)
            {
                MessageBox.Show("Вы ввели не число!!!");
            }
            else
            {
                if (DataBank.Logik == 0) DataBank.PrintListBox(listBoxCalculate);
                else if (DataBank.Logik == 1) DataBank.AddElementesN(listBoxCalculate, number);
                else if (DataBank.Logik == 2) DataBank.AddElementesK(listBoxCalculate, number);
                else if (DataBank.Logik == 3) DataBank.AddElementesP(listBoxCalculate, number);
                else if (DataBank.Logik == 4) DataBank.DelElementesN(listBoxCalculate);
                else if (DataBank.Logik == 5) DataBank.DelElementesK(listBoxCalculate);
                else if (DataBank.Logik == 6) DataBank.DelElementesP(listBoxCalculate);
                else if (DataBank.Logik == 7) DataBank.DelSpisok(listBoxCalculate);

                textBoxElement.Clear();
            }
        }
    }
}
