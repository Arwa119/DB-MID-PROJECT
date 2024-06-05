namespace DBWindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TLPtop = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TLPSide = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAttendence = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonRubrix = new System.Windows.Forms.Button();
            this.buttonAsses = new System.Windows.Forms.Button();
            this.buttonCLO = new System.Windows.Forms.Button();
            this.StudentButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlFill = new System.Windows.Forms.Panel();
            this.PnlPage = new System.Windows.Forms.Panel();
            this.ElipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipsepNlPage = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TLPtop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TLPSide.SuspendLayout();
            this.PnlFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPtop
            // 
            this.TLPtop.ColumnCount = 8;
            this.TLPtop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.TLPtop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.TLPtop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.223242F));
            this.TLPtop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.77676F));
            this.TLPtop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.TLPtop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TLPtop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TLPtop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.TLPtop.Controls.Add(this.buttonMinimize, 5, 0);
            this.TLPtop.Controls.Add(this.buttonMaximize, 6, 0);
            this.TLPtop.Controls.Add(this.buttonClose, 7, 0);
            this.TLPtop.Controls.Add(this.label1, 3, 0);
            this.TLPtop.Controls.Add(this.label2, 1, 0);
            this.TLPtop.Controls.Add(this.pictureBox2, 0, 0);
            this.TLPtop.Controls.Add(this.pictureBox1, 4, 0);
            this.TLPtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLPtop.Location = new System.Drawing.Point(0, 0);
            this.TLPtop.Margin = new System.Windows.Forms.Padding(0);
            this.TLPtop.Name = "TLPtop";
            this.TLPtop.RowCount = 1;
            this.TLPtop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.TLPtop.Size = new System.Drawing.Size(1340, 56);
            this.TLPtop.TabIndex = 0;
            this.TLPtop.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(1192, 0);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(42, 56);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
            this.buttonMaximize.Location = new System.Drawing.Point(1234, 0);
            this.buttonMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(42, 56);
            this.buttonMaximize.TabIndex = 1;
            this.buttonMaximize.TabStop = false;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(1276, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(64, 56);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(199, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(935, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "LAB MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 56);
            this.label2.TabIndex = 5;
            this.label2.Text = "LMS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(12, 4, 0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1134, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TLPSide
            // 
            this.TLPSide.ColumnCount = 1;
            this.TLPSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.TLPSide.Controls.Add(this.buttonAttendence, 0, 6);
            this.TLPSide.Controls.Add(this.buttonReport, 0, 5);
            this.TLPSide.Controls.Add(this.buttonResult, 0, 4);
            this.TLPSide.Controls.Add(this.buttonRubrix, 0, 3);
            this.TLPSide.Controls.Add(this.buttonAsses, 0, 2);
            this.TLPSide.Controls.Add(this.buttonCLO, 0, 1);
            this.TLPSide.Controls.Add(this.StudentButton, 0, 0);
            this.TLPSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.TLPSide.Location = new System.Drawing.Point(0, 56);
            this.TLPSide.Margin = new System.Windows.Forms.Padding(0);
            this.TLPSide.Name = "TLPSide";
            this.TLPSide.RowCount = 8;
            this.TLPSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.TLPSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.TLPSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.TLPSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.TLPSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.TLPSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.TLPSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.TLPSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPSide.Size = new System.Drawing.Size(136, 615);
            this.TLPSide.TabIndex = 1;
            this.TLPSide.Paint += new System.Windows.Forms.PaintEventHandler(this.TLPSide_Paint);
            // 
            // buttonAttendence
            // 
            this.buttonAttendence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAttendence.FlatAppearance.BorderSize = 0;
            this.buttonAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendence.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttendence.ImageIndex = 11;
            this.buttonAttendence.ImageList = this.ImageList1;
            this.buttonAttendence.Location = new System.Drawing.Point(8, 477);
            this.buttonAttendence.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonAttendence.Name = "buttonAttendence";
            this.buttonAttendence.Size = new System.Drawing.Size(120, 60);
            this.buttonAttendence.TabIndex = 9;
            this.buttonAttendence.Text = "Attendence";
            this.buttonAttendence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAttendence.UseVisualStyleBackColor = true;
            this.buttonAttendence.Click += new System.EventHandler(this.button7_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "icons8-boxes-50 (1).png");
            this.ImageList1.Images.SetKeyName(1, "icons8-boxes-50.png");
            this.ImageList1.Images.SetKeyName(2, "icons8-rubik\'s-cube-50 (1).png");
            this.ImageList1.Images.SetKeyName(3, "icons8-rubik\'s-cube-50.png");
            this.ImageList1.Images.SetKeyName(4, "icons8-business-report-50 (1).png");
            this.ImageList1.Images.SetKeyName(5, "icons8-business-report-50.png");
            this.ImageList1.Images.SetKeyName(6, "icons8-user-50 (1).png");
            this.ImageList1.Images.SetKeyName(7, "icons8-user-50.png");
            this.ImageList1.Images.SetKeyName(8, "icons8-paper-50 (2).png");
            this.ImageList1.Images.SetKeyName(9, "icons8-paper-50 (1).png");
            this.ImageList1.Images.SetKeyName(10, "icons8-paper-50.png");
            this.ImageList1.Images.SetKeyName(11, "icons8-list-50.png");
            this.ImageList1.Images.SetKeyName(12, "icons8-list-50 (1).png");
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.ImageIndex = 5;
            this.buttonReport.ImageList = this.ImageList1;
            this.buttonReport.Location = new System.Drawing.Point(8, 399);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(120, 60);
            this.buttonReport.TabIndex = 8;
            this.buttonReport.Text = "Reports";
            this.buttonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResult.FlatAppearance.BorderSize = 0;
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResult.ImageIndex = 8;
            this.buttonResult.ImageList = this.ImageList1;
            this.buttonResult.Location = new System.Drawing.Point(8, 321);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(120, 60);
            this.buttonResult.TabIndex = 7;
            this.buttonResult.Text = "Results";
            this.buttonResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonRubrix
            // 
            this.buttonRubrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRubrix.FlatAppearance.BorderSize = 0;
            this.buttonRubrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRubrix.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRubrix.ImageIndex = 3;
            this.buttonRubrix.ImageList = this.ImageList1;
            this.buttonRubrix.Location = new System.Drawing.Point(8, 243);
            this.buttonRubrix.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonRubrix.Name = "buttonRubrix";
            this.buttonRubrix.Size = new System.Drawing.Size(120, 60);
            this.buttonRubrix.TabIndex = 6;
            this.buttonRubrix.Text = "Rubrics";
            this.buttonRubrix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRubrix.UseVisualStyleBackColor = true;
            this.buttonRubrix.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonAsses
            // 
            this.buttonAsses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAsses.FlatAppearance.BorderSize = 0;
            this.buttonAsses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsses.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsses.ImageIndex = 10;
            this.buttonAsses.ImageList = this.ImageList1;
            this.buttonAsses.Location = new System.Drawing.Point(8, 165);
            this.buttonAsses.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonAsses.Name = "buttonAsses";
            this.buttonAsses.Size = new System.Drawing.Size(120, 60);
            this.buttonAsses.TabIndex = 5;
            this.buttonAsses.Text = "Assesment";
            this.buttonAsses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAsses.UseVisualStyleBackColor = true;
            this.buttonAsses.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCLO
            // 
            this.buttonCLO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCLO.FlatAppearance.BorderSize = 0;
            this.buttonCLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCLO.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCLO.ImageIndex = 1;
            this.buttonCLO.ImageList = this.ImageList1;
            this.buttonCLO.Location = new System.Drawing.Point(8, 87);
            this.buttonCLO.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonCLO.Name = "buttonCLO";
            this.buttonCLO.Size = new System.Drawing.Size(120, 60);
            this.buttonCLO.TabIndex = 4;
            this.buttonCLO.Text = "CLO";
            this.buttonCLO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCLO.UseVisualStyleBackColor = true;
            this.buttonCLO.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentButton
            // 
            this.StudentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentButton.FlatAppearance.BorderSize = 0;
            this.StudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentButton.ImageIndex = 6;
            this.StudentButton.ImageList = this.ImageList1;
            this.StudentButton.Location = new System.Drawing.Point(8, 9);
            this.StudentButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(120, 60);
            this.StudentButton.TabIndex = 3;
            this.StudentButton.Text = "Student";
            this.StudentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StudentButton.UseVisualStyleBackColor = true;
            this.StudentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(5, 60);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // PnlFill
            // 
            this.PnlFill.Controls.Add(this.PnlPage);
            this.PnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFill.Location = new System.Drawing.Point(136, 56);
            this.PnlFill.Name = "PnlFill";
            this.PnlFill.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.PnlFill.Size = new System.Drawing.Size(1204, 615);
            this.PnlFill.TabIndex = 3;
            this.PnlFill.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFill_Paint);
            // 
            // PnlPage
            // 
            this.PnlPage.BackColor = System.Drawing.Color.White;
            this.PnlPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPage.Location = new System.Drawing.Point(0, 0);
            this.PnlPage.Name = "PnlPage";
            this.PnlPage.Size = new System.Drawing.Size(1194, 605);
            this.PnlPage.TabIndex = 0;
            this.PnlPage.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPage_Paint);
            // 
            // ElipseForm
            // 
            this.ElipseForm.ElipseRadius = 20;
            this.ElipseForm.TargetControl = this;
            // 
            // ElipsepNlPage
            // 
            this.ElipsepNlPage.ElipseRadius = 15;
            this.ElipsepNlPage.TargetControl = this.PnlPage;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1340, 671);
            this.Controls.Add(this.PnlFill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TLPSide);
            this.Controls.Add(this.TLPtop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TLPtop.ResumeLayout(false);
            this.TLPtop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TLPSide.ResumeLayout(false);
            this.PnlFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPtop;
        private System.Windows.Forms.TableLayoutPanel TLPSide;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button buttonRubrix;
        private System.Windows.Forms.Button buttonAsses;
        private System.Windows.Forms.Button buttonCLO;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonAttendence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PnlFill;
        private System.Windows.Forms.Panel PnlPage;
        private Bunifu.Framework.UI.BunifuElipse ElipseForm;
        private Bunifu.Framework.UI.BunifuElipse ElipsepNlPage;
    }
}

