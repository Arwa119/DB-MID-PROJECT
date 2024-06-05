using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
namespace DBWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        void SelectBtn(Button btn)
        {
            switch (btn.Name)
            {
                case "StudentButton":btn.ImageIndex = 7; break;
                case "buttonCLO": btn.ImageIndex = 0; break;
                case "buttonAsses": btn.ImageIndex = 9; break;
                case "buttonRubrix": btn.ImageIndex = 2; break;
                case "buttonResult": btn.ImageIndex = 8; break;
                case "buttonReport": btn.ImageIndex = 4; break;
                case "buttonAttendence": btn.ImageIndex = 11; break;
                default:break;    
            }
            btn.BackColor = Color.FromArgb(17, 147, 255);
            label4.Top = btn.Top;
            label4.Height = btn.Height - 20;
            label4.Location = new Point(btn.Location.X,btn.Location.Y+65);
        }
        void ResetBtn()
        {
            foreach (var btn in TLPSide.Controls.OfType<Button>()) 
            {
                btn.BackColor = Color.FromArgb(17,153,248);
            }
            StudentButton.ImageIndex = 6;
            buttonCLO.ImageIndex = 1;
            buttonAsses.ImageIndex = 10;
            buttonRubrix.ImageIndex = 3;
            buttonResult.ImageIndex = 8;
            buttonReport.ImageIndex = 5;
            buttonAttendence.ImageIndex = 12;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LMS_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TLPSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetBtn();
            SelectBtn(StudentButton);
            loadForm(new StudentForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetBtn();
            SelectBtn(buttonCLO);
            loadForm(new CLOForm());

        }

        private void PnlFill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnlPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetBtn();
            SelectBtn(buttonAsses);
            loadForm(new Assesment());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetBtn();
            SelectBtn(buttonRubrix);
            loadForm(new RubrixForm());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetBtn();
            SelectBtn(buttonResult);
            loadForm(new Results());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResetBtn();
            SelectBtn(buttonReport);
            loadForm(new ReportForm());

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResetBtn();
            SelectBtn(buttonAttendence);
            loadForm(new ClassAttendence());
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            { WindowState = FormWindowState.Maximized;}
        }
        public void loadForm(object Form)
        {
            if (this.PnlPage.Controls.Count > 0)
                this.PnlPage.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PnlPage.Controls.Add(f);
            this.PnlPage.Tag= f;
            f.Show();
        }
    }
}
