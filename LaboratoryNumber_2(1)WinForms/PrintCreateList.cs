﻿using System;
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
    public partial class PrintCreateList : Form
    {
        public PrintCreateList()
        {
            InitializeComponent();
            listBoxPrintList.Items.Clear();
            DataBank.PrintListBox(listBoxPrintList);
        }
    }
}
