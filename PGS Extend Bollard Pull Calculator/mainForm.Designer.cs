namespace WindowsFormsApplication1
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tBoxShipLength = new System.Windows.Forms.TextBox();
            this.tBoxFreebroad = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genertateNewShipxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadShipxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxShipChoose = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxContainerHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tBoxWindBearing = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxNumberOfTugs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxShipLength
            // 
            this.tBoxShipLength.Location = new System.Drawing.Point(128, 73);
            this.tBoxShipLength.Name = "tBoxShipLength";
            this.tBoxShipLength.Size = new System.Drawing.Size(100, 20);
            this.tBoxShipLength.TabIndex = 1;
            this.tBoxShipLength.Text = "0m";
            // 
            // tBoxFreebroad
            // 
            this.tBoxFreebroad.Location = new System.Drawing.Point(128, 99);
            this.tBoxFreebroad.Name = "tBoxFreebroad";
            this.tBoxFreebroad.Size = new System.Drawing.Size(100, 20);
            this.tBoxFreebroad.TabIndex = 2;
            this.tBoxFreebroad.Text = "0m";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "0Knots";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Windage Area: Undefined ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(128, 231);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Bollard Pull: Undefined";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genertateNewShipxmlToolStripMenuItem,
            this.reloadShipxmlToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // genertateNewShipxmlToolStripMenuItem
            // 
            this.genertateNewShipxmlToolStripMenuItem.Name = "genertateNewShipxmlToolStripMenuItem";
            this.genertateNewShipxmlToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.genertateNewShipxmlToolStripMenuItem.Text = "Genertate New Ship.xml";
            this.genertateNewShipxmlToolStripMenuItem.Click += new System.EventHandler(this.genertateNewShipxmlToolStripMenuItem_Click);
            // 
            // reloadShipxmlToolStripMenuItem
            // 
            this.reloadShipxmlToolStripMenuItem.Name = "reloadShipxmlToolStripMenuItem";
            this.reloadShipxmlToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.reloadShipxmlToolStripMenuItem.Text = "Reload Ship.xml";
            this.reloadShipxmlToolStripMenuItem.Click += new System.EventHandler(this.reloadShipxmlToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bollard Pull per Tug: Undefined";
            // 
            // cBoxShipChoose
            // 
            this.cBoxShipChoose.FormattingEnabled = true;
            this.cBoxShipChoose.Location = new System.Drawing.Point(61, 46);
            this.cBoxShipChoose.Name = "cBoxShipChoose";
            this.cBoxShipChoose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBoxShipChoose.Size = new System.Drawing.Size(167, 21);
            this.cBoxShipChoose.TabIndex = 0;
            this.cBoxShipChoose.Text = "<--Choose Ship-->";
            this.cBoxShipChoose.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ship Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ship Freeboard";
            // 
            // tBoxContainerHeight
            // 
            this.tBoxContainerHeight.Location = new System.Drawing.Point(128, 125);
            this.tBoxContainerHeight.Name = "tBoxContainerHeight";
            this.tBoxContainerHeight.Size = new System.Drawing.Size(100, 20);
            this.tBoxContainerHeight.TabIndex = 3;
            this.tBoxContainerHeight.Text = "0m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ship Container Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Wind Velocity";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // tBoxWindBearing
            // 
            this.tBoxWindBearing.Location = new System.Drawing.Point(128, 178);
            this.tBoxWindBearing.Name = "tBoxWindBearing";
            this.tBoxWindBearing.Size = new System.Drawing.Size(100, 20);
            this.tBoxWindBearing.TabIndex = 5;
            this.tBoxWindBearing.Text = "000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Wind Direction Bearing";
            // 
            // tBoxNumberOfTugs
            // 
            this.tBoxNumberOfTugs.Location = new System.Drawing.Point(128, 205);
            this.tBoxNumberOfTugs.Name = "tBoxNumberOfTugs";
            this.tBoxNumberOfTugs.Size = new System.Drawing.Size(100, 20);
            this.tBoxNumberOfTugs.TabIndex = 6;
            this.tBoxNumberOfTugs.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Number of Tugs";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 419);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tBoxNumberOfTugs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBoxWindBearing);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBoxContainerHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxShipChoose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tBoxFreebroad);
            this.Controls.Add(this.tBoxShipLength);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 458);
            this.MinimumSize = new System.Drawing.Size(700, 458);
            this.Name = "mainForm";
            this.Text = "Bollard Pull Calculator - Albert Johnson Quay - Portsmouth";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxShipLength;
        private System.Windows.Forms.TextBox tBoxFreebroad;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem genertateNewShipxmlToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBoxShipChoose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxContainerHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBoxWindBearing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxNumberOfTugs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem reloadShipxmlToolStripMenuItem;
    }
}

