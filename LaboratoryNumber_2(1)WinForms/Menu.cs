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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти из программы?", "Проверка выхода", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataBank.DestroyL();
                this.Close();
            }
        }

        private void созданиеСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.L1 = new SingleLinkedList();
            int[] dates = new int[listBox.Items.Count];
            for (int i = 0; i < listBox.Items.Count; i++) dates[i] = int.Parse(listBox.Items[i].ToString());
            DataBank.CreatMassL1(dates);
            //Отдельная форма для демонтсрации созданного списка
            //PrintCreateList Fprntlst = new PrintCreateList();
            //Fprntlst.Show();
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
            if (listBox.SelectedIndex > -1) listBox.Items.RemoveAt(listBox.SelectedIndex);
        }

        private void вНачалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.logicTask = "1";
            PatternAddInList_StartEnd PtrnAddLst = new PatternAddInList_StartEnd();
            PtrnAddLst.Show();
        }

        private void вКонецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.logicTask = "2";
            PatternAddInList_StartEnd PtrnAddLst = new PatternAddInList_StartEnd();
            PtrnAddLst.Show();
        }

        private void вПроизвольнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.logicTask = "3";
            PatternAddInList_Random PtrnAddLstRnd = new PatternAddInList_Random();
            PtrnAddLstRnd.Show();
        }

        private void вНачалоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataBank.logicTask = "-1";
            PatternDelInList_StartEnd PtrnAddLst = new PatternDelInList_StartEnd();
            PtrnAddLst.Show();
        }

        private void вКонецToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataBank.logicTask = "-2";
            PatternDelInList_StartEnd PtrnAddLst = new PatternDelInList_StartEnd();
            PtrnAddLst.Show();
        }

        private void вПроизвольнуюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataBank.logicTask = "-3";
            PatternDelInList_Random PtrnDelLstRnd = new PatternDelInList_Random();
            PtrnDelLstRnd.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramInfo PrgrmInf = new ProgramInfo();
            PrgrmInf.Show();
        }

        private void обработкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyTask14 Mtsk = new MyTask14();
            Mtsk.Show();
        }

        private void разрушениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.DestroyL();
        }

        private void doubleListNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintCreateList Fprntlst = new PrintCreateList();
            Fprntlst.Show();
        }
    }
}
