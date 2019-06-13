namespace ProcessShield
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.themeContainer1 = new ProcessShield.Theme.ThemeContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.filesizeChangeLbl = new System.Windows.Forms.Label();
            this.filesizeLbl = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputLbl = new System.Windows.Forms.Label();
            this.dirTextBox1 = new System.Windows.Forms.TextBox();
            this.dirLbl = new System.Windows.Forms.Label();
            this.roundPanel1 = new ProcessShield.Theme.RoundPanel();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.extraListBox2 = new ProcessShield.Theme.ExtraListBox();
            this.extraListBox1 = new ProcessShield.Theme.ExtraListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nopCheckBox = new System.Windows.Forms.CheckBox();
            this.protectBtn = new System.Windows.Forms.Button();
            this.roundPanel2 = new ProcessShield.Theme.RoundPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.titleBar1 = new ProcessShield.Theme.TitleBar();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.memLoadCheckBox = new System.Windows.Forms.CheckBox();
            this.themeContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.titleBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // themeContainer1
            // 
            this.themeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.themeContainer1.Controls.Add(this.tabControl1);
            this.themeContainer1.Controls.Add(this.titleBar1);
            this.themeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeContainer1.Location = new System.Drawing.Point(0, 0);
            this.themeContainer1.Name = "themeContainer1";
            this.themeContainer1.Size = new System.Drawing.Size(435, 368);
            this.themeContainer1.TabIndex = 0;
            this.themeContainer1.Text = "themeContainer1";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 334);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.filesizeChangeLbl);
            this.tabPage3.Controls.Add(this.filesizeLbl);
            this.tabPage3.Controls.Add(this.outputTextBox);
            this.tabPage3.Controls.Add(this.outputLbl);
            this.tabPage3.Controls.Add(this.dirTextBox1);
            this.tabPage3.Controls.Add(this.dirLbl);
            this.tabPage3.Controls.Add(this.roundPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(421, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Assembly";
            // 
            // filesizeChangeLbl
            // 
            this.filesizeChangeLbl.AutoSize = true;
            this.filesizeChangeLbl.Location = new System.Drawing.Point(73, 108);
            this.filesizeChangeLbl.Name = "filesizeChangeLbl";
            this.filesizeChangeLbl.Size = new System.Drawing.Size(13, 13);
            this.filesizeChangeLbl.TabIndex = 6;
            this.filesizeChangeLbl.Text = "0";
            // 
            // filesizeLbl
            // 
            this.filesizeLbl.AutoSize = true;
            this.filesizeLbl.Location = new System.Drawing.Point(5, 108);
            this.filesizeLbl.Name = "filesizeLbl";
            this.filesizeLbl.Size = new System.Drawing.Size(75, 13);
            this.filesizeLbl.TabIndex = 5;
            this.filesizeLbl.Text = "File Size(kb): ";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(71, 50);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(345, 22);
            this.outputTextBox.TabIndex = 4;
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(5, 55);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(48, 13);
            this.outputLbl.TabIndex = 3;
            this.outputLbl.Text = "Output: ";
            // 
            // dirTextBox1
            // 
            this.dirTextBox1.Location = new System.Drawing.Point(71, 8);
            this.dirTextBox1.Name = "dirTextBox1";
            this.dirTextBox1.Size = new System.Drawing.Size(345, 22);
            this.dirTextBox1.TabIndex = 2;
            // 
            // dirLbl
            // 
            this.dirLbl.AutoSize = true;
            this.dirLbl.Location = new System.Drawing.Point(5, 11);
            this.dirLbl.Name = "dirLbl";
            this.dirLbl.Size = new System.Drawing.Size(60, 13);
            this.dirLbl.TabIndex = 1;
            this.dirLbl.Text = "Directory: ";
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.LightGray;
            this.roundPanel1.Controls.Add(this.dragPanel);
            this.roundPanel1.Location = new System.Drawing.Point(5, 124);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(413, 176);
            this.roundPanel1.TabIndex = 0;
            // 
            // dragPanel
            // 
            this.dragPanel.AllowDrop = true;
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(413, 176);
            this.dragPanel.TabIndex = 0;
            this.dragPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragPanel_DragDrop);
            this.dragPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragPanel_DragEnter);
            this.dragPanel.DragOver += new System.Windows.Forms.DragEventHandler(this.dragPanel_DragOver);
            this.dragPanel.DragLeave += new System.EventHandler(this.dragPanel_DragLeave);
            this.dragPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dragPanel_Paint);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.extraListBox2);
            this.tabPage1.Controls.Add(this.extraListBox1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Protections";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Plugins";
            // 
            // extraListBox2
            // 
            this.extraListBox2.BackColor = System.Drawing.Color.White;
            this.extraListBox2.BorderColor = System.Drawing.Color.Black;
            this.extraListBox2.BorderOpacity = ProcessShield.Theme.OpacityScale.Half;
            this.extraListBox2.BorderSize = 1;
            this.extraListBox2.CenterTitle = false;
            this.extraListBox2.DrawBorder = true;
            this.extraListBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.extraListBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraListBox2.FormattingEnabled = true;
            this.extraListBox2.Location = new System.Drawing.Point(233, 18);
            this.extraListBox2.Name = "extraListBox2";
            this.extraListBox2.ScrollAlwaysVisible = true;
            this.extraListBox2.Size = new System.Drawing.Size(184, 281);
            this.extraListBox2.TabIndex = 1;
            this.extraListBox2.TitleColor = System.Drawing.Color.Green;
            this.extraListBox2.TitleFont = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraListBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.extraListBox2_MouseDoubleClick);
            // 
            // extraListBox1
            // 
            this.extraListBox1.BackColor = System.Drawing.Color.White;
            this.extraListBox1.BorderColor = System.Drawing.Color.Black;
            this.extraListBox1.BorderOpacity = ProcessShield.Theme.OpacityScale.Max;
            this.extraListBox1.BorderSize = 1;
            this.extraListBox1.CenterTitle = false;
            this.extraListBox1.DrawBorder = true;
            this.extraListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.extraListBox1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.extraListBox1.FormattingEnabled = true;
            this.extraListBox1.Location = new System.Drawing.Point(3, 19);
            this.extraListBox1.Name = "extraListBox1";
            this.extraListBox1.ScrollAlwaysVisible = true;
            this.extraListBox1.Size = new System.Drawing.Size(184, 281);
            this.extraListBox1.TabIndex = 0;
            this.extraListBox1.TitleColor = System.Drawing.Color.Red;
            this.extraListBox1.TitleFont = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraListBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.extraListBox1_MouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.memLoadCheckBox);
            this.tabPage2.Controls.Add(this.nopCheckBox);
            this.tabPage2.Controls.Add(this.protectBtn);
            this.tabPage2.Controls.Add(this.roundPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Protect";
            // 
            // nopCheckBox
            // 
            this.nopCheckBox.AutoSize = true;
            this.nopCheckBox.FlatAppearance.BorderSize = 0;
            this.nopCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.nopCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nopCheckBox.Location = new System.Drawing.Point(6, 232);
            this.nopCheckBox.Name = "nopCheckBox";
            this.nopCheckBox.Size = new System.Drawing.Size(137, 17);
            this.nopCheckBox.TabIndex = 2;
            this.nopCheckBox.Text = "[nop] Dos Information";
            this.nopCheckBox.UseVisualStyleBackColor = true;
            // 
            // protectBtn
            // 
            this.protectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.protectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.protectBtn.Location = new System.Drawing.Point(331, 251);
            this.protectBtn.Name = "protectBtn";
            this.protectBtn.Size = new System.Drawing.Size(87, 36);
            this.protectBtn.TabIndex = 1;
            this.protectBtn.Text = "Protect";
            this.protectBtn.UseVisualStyleBackColor = true;
            this.protectBtn.Click += new System.EventHandler(this.protectBtn_Click);
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.Silver;
            this.roundPanel2.Controls.Add(this.richTextBox1);
            this.roundPanel2.Location = new System.Drawing.Point(3, 6);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(415, 220);
            this.roundPanel2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(409, 214);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // titleBar1
            // 
            this.titleBar1.Controls.Add(this.exitBtn);
            this.titleBar1.Controls.Add(this.pictureBox1);
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Font = new System.Drawing.Font("Verdana", 9F);
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(435, 25);
            this.titleBar1.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(412, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(23, 20);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // memLoadCheckBox
            // 
            this.memLoadCheckBox.AutoSize = true;
            this.memLoadCheckBox.FlatAppearance.BorderSize = 0;
            this.memLoadCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.memLoadCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memLoadCheckBox.Location = new System.Drawing.Point(6, 255);
            this.memLoadCheckBox.Name = "memLoadCheckBox";
            this.memLoadCheckBox.Size = new System.Drawing.Size(153, 17);
            this.memLoadCheckBox.TabIndex = 3;
            this.memLoadCheckBox.Text = "Generate Memory Loader";
            this.memLoadCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(435, 368);
            this.Controls.Add(this.themeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.themeContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.roundPanel1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.roundPanel2.ResumeLayout(false);
            this.titleBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Theme.ThemeContainer themeContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Theme.TitleBar titleBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Theme.RoundPanel roundPanel1;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.TextBox dirTextBox1;
        private System.Windows.Forms.Label dirLbl;
        private System.Windows.Forms.Label filesizeChangeLbl;
        private System.Windows.Forms.Label filesizeLbl;
        private Theme.ExtraListBox extraListBox1;
        private Theme.ExtraListBox extraListBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Theme.RoundPanel roundPanel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button protectBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox nopCheckBox;
        private System.Windows.Forms.CheckBox memLoadCheckBox;
    }
}

