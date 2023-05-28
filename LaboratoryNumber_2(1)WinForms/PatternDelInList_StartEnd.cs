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
    public partial class PatternDelInList_StartEnd : Form
    {
        public PatternDelInList_StartEnd()
        {
            InitializeComponent();
            DataBank.PrintListBox(listBoxPatternDelInList);
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (DataBank.logicTask == "-1")
            {
                listBoxPatternDelInList.Items.Clear();
                DataBank.DelElementsN(listBoxPatternDelInList);
                
            }
            else if (DataBank.logicTask == "-2")
            {
                listBoxPatternDelInList.Items.Clear();
                DataBank.DelElementsK(listBoxPatternDelInList);
                
            }
            DataBank.PrintListBox(listBoxPatternDelInList);
        }
    }
}
