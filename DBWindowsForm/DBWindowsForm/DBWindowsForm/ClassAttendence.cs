using System;
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
    public partial class ClassAttendence : Form
    {
        public ClassAttendence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentAttendence student = new StudentAttendence();
            student.Show();
        }
    }
}
