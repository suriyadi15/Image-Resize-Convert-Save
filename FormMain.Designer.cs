namespace Image_Resize_Convert_Save
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxOri = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProccess = new System.Windows.Forms.Button();
            this.comboBoxPixelFormat = new System.Windows.Forms.ComboBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.saveResultImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOri)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.saveResultImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 270);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Image";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxOri);
            this.panel1.Location = new System.Drawing.Point(10, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 245);
            this.panel1.TabIndex = 3;
            // 
            // pictureBoxOri
            // 
            this.pictureBoxOri.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxOri.Name = "pictureBoxOri";
            this.pictureBoxOri.Size = new System.Drawing.Size(248, 239);
            this.pictureBoxOri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOri.TabIndex = 0;
            this.pictureBoxOri.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(292, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 270);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result Image";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxResult);
            this.panel2.Location = new System.Drawing.Point(10, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 245);
            this.panel2.TabIndex = 3;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(248, 239);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 0;
            this.pictureBoxResult.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Piksel Format";
            // 
            // buttonProccess
            // 
            this.buttonProccess.Location = new System.Drawing.Point(468, 24);
            this.buttonProccess.Name = "buttonProccess";
            this.buttonProccess.Size = new System.Drawing.Size(76, 23);
            this.buttonProccess.TabIndex = 3;
            this.buttonProccess.Text = "Proses";
            this.buttonProccess.UseVisualStyleBackColor = true;
            this.buttonProccess.Click += new System.EventHandler(this.buttonProccess_Click);
            // 
            // comboBoxPixelFormat
            // 
            this.comboBoxPixelFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPixelFormat.FormattingEnabled = true;
            this.comboBoxPixelFormat.Items.AddRange(new object[] {
            "24bppRGB",
            "32bppRGB",
            "32bppARGB"});
            this.comboBoxPixelFormat.Location = new System.Drawing.Point(361, 26);
            this.comboBoxPixelFormat.Name = "comboBoxPixelFormat";
            this.comboBoxPixelFormat.Size = new System.Drawing.Size(101, 21);
            this.comboBoxPixelFormat.TabIndex = 2;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(211, 26);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(68, 20);
            this.textBoxHeight.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Max Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Max Height";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(70, 26);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(68, 20);
            this.textBoxWidth.TabIndex = 0;
            // 
            // saveResultImageToolStripMenuItem
            // 
            this.saveResultImageToolStripMenuItem.Name = "saveResultImageToolStripMenuItem";
            this.saveResultImageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.saveResultImageToolStripMenuItem.Text = "Save Result Image";
            this.saveResultImageToolStripMenuItem.Click += new System.EventHandler(this.saveResultImageToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxWidth);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonProccess);
            this.groupBox3.Controls.Add(this.comboBoxPixelFormat);
            this.groupBox3.Controls.Add(this.textBoxHeight);
            this.groupBox3.Location = new System.Drawing.Point(12, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 62);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 373);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resize Convert Save Image";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOri)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxOri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProccess;
        private System.Windows.Forms.ComboBox comboBoxPixelFormat;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.ToolStripMenuItem saveResultImageToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

