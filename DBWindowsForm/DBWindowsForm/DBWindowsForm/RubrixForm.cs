﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWindowsForm
{
    public partial class RubrixForm : Form
    {
        public RubrixForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RubrixLevel rubrixLevel = new RubrixLevel();
            rubrixLevel.Show();
        }
    }
}