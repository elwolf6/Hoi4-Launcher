﻿namespace Hoi4_Launcher
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.list_dlc = new System.Windows.Forms.CheckedListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.list_mods = new System.Windows.Forms.CheckedListBox();
			this.categoriesBox = new System.Windows.Forms.ComboBox();
			this.label_category = new System.Windows.Forms.Label();
			this.label_mods = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.toggle_debug = new System.Windows.Forms.CheckBox();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.RichTextBox();
			this.closebutton = new System.Windows.Forms.Button();
			this.userControl11 = new ImgButton.UserControl1();
			this.label_version = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Location = new System.Drawing.Point(437, 35);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(541, 402);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabPage1.BackgroundImage = global::Hoi4_Launcher.Properties.Resources.listBG;
			this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(533, 376);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "News";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.list_dlc);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(533, 376);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "DLC";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// list_dlc
			// 
			this.list_dlc.CheckOnClick = true;
			this.list_dlc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.list_dlc.FormattingEnabled = true;
			this.list_dlc.Location = new System.Drawing.Point(3, 3);
			this.list_dlc.Name = "list_dlc";
			this.list_dlc.Size = new System.Drawing.Size(527, 370);
			this.list_dlc.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.button2);
			this.tabPage3.Controls.Add(this.list_mods);
			this.tabPage3.Controls.Add(this.categoriesBox);
			this.tabPage3.Controls.Add(this.label_category);
			this.tabPage3.Controls.Add(this.label_mods);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(533, 376);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Mods";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(412, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(118, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Update Steam Mods";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// list_mods
			// 
			this.list_mods.CheckOnClick = true;
			this.list_mods.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.list_mods.FormattingEnabled = true;
			this.list_mods.Location = new System.Drawing.Point(0, 27);
			this.list_mods.Name = "list_mods";
			this.list_mods.Size = new System.Drawing.Size(533, 349);
			this.list_mods.Sorted = true;
			this.list_mods.TabIndex = 4;
			// 
			// categoriesBox
			// 
			this.categoriesBox.FormattingEnabled = true;
			this.categoriesBox.Location = new System.Drawing.Point(61, 5);
			this.categoriesBox.Name = "categoriesBox";
			this.categoriesBox.Size = new System.Drawing.Size(218, 21);
			this.categoriesBox.Sorted = true;
			this.categoriesBox.TabIndex = 3;
			// 
			// label_category
			// 
			this.label_category.AutoSize = true;
			this.label_category.Location = new System.Drawing.Point(3, 10);
			this.label_category.Name = "label_category";
			this.label_category.Size = new System.Drawing.Size(52, 13);
			this.label_category.TabIndex = 2;
			this.label_category.Text = "Category:";
			// 
			// label_mods
			// 
			this.label_mods.AutoSize = true;
			this.label_mods.Location = new System.Drawing.Point(285, 11);
			this.label_mods.Name = "label_mods";
			this.label_mods.Size = new System.Drawing.Size(36, 13);
			this.label_mods.TabIndex = 1;
			this.label_mods.Text = "Mods:";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.toggle_debug);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(533, 376);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Settings";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// toggle_debug
			// 
			this.toggle_debug.AutoSize = true;
			this.toggle_debug.Location = new System.Drawing.Point(7, 7);
			this.toggle_debug.Name = "toggle_debug";
			this.toggle_debug.Size = new System.Drawing.Size(94, 17);
			this.toggle_debug.TabIndex = 0;
			this.toggle_debug.Text = "Enable Debug";
			this.toggle_debug.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.textBox1);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(533, 376);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Log";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(527, 370);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// closebutton
			// 
			this.closebutton.BackColor = System.Drawing.Color.Transparent;
			this.closebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closebutton.BackgroundImage")));
			this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.closebutton.FlatAppearance.BorderSize = 0;
			this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closebutton.ForeColor = System.Drawing.Color.Transparent;
			this.closebutton.Location = new System.Drawing.Point(953, 12);
			this.closebutton.Name = "closebutton";
			this.closebutton.Size = new System.Drawing.Size(32, 32);
			this.closebutton.TabIndex = 7;
			this.closebutton.UseVisualStyleBackColor = false;
			this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
			// 
			// userControl11
			// 
			this.userControl11._3rdParty = false;
			this.userControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.userControl11.BackColor = System.Drawing.Color.Transparent;
			this.userControl11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl11.BackgroundImage")));
			this.userControl11.Location = new System.Drawing.Point(577, 477);
			this.userControl11.Name = "userControl11";
			this.userControl11.Size = new System.Drawing.Size(411, 79);
			this.userControl11.TabIndex = 4;
			this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
			this.userControl11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserControl11_Click);
			// 
			// label_version
			// 
			this.label_version.AutoSize = true;
			this.label_version.BackColor = System.Drawing.Color.Transparent;
			this.label_version.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_version.ForeColor = System.Drawing.Color.White;
			this.label_version.Location = new System.Drawing.Point(13, 573);
			this.label_version.Name = "label_version";
			this.label_version.Size = new System.Drawing.Size(42, 13);
			this.label_version.TabIndex = 8;
			this.label_version.Text = "Version";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1000, 598);
			this.Controls.Add(this.label_version);
			this.Controls.Add(this.closebutton);
			this.Controls.Add(this.userControl11);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Hearts of Iron IV Launcher";
			this.Load += new System.EventHandler(this.Form1_Load_1);
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label_mods;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.ComboBox categoriesBox;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.CheckedListBox list_mods;
        private System.Windows.Forms.CheckedListBox list_dlc;
        private ImgButton.UserControl1 userControl11;
		private System.Windows.Forms.Button closebutton;
		private System.Windows.Forms.CheckBox toggle_debug;
		private System.Windows.Forms.Label label_version;
		private System.Windows.Forms.Button button2;
	}
}

