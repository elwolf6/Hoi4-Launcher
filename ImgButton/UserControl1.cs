﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ImgButton
{
    public partial class UserControl2 : UserControl
    {
        [Category("Custom")]
        [Browsable(true)]
        public UserControl2()
        {
            InitializeComponent();
        }
       

        private void UserControl1_Load(object sender, EventArgs e)
        {
           // this.MouseHover += new System.EventHandler(UserControl1_Hover);
           // pictureBox1.MouseHover += new System.EventHandler(UserControl1_Hover);
            //label1.MouseHover += new System.EventHandler(UserControl1_Hover);

            //this.MouseLeave += new System.EventHandler(UserControl1_Leave);

            this.Click += new System.EventHandler(UserControl1_Click);
            pictureBox1.Click += new System.EventHandler(UserControl1_Click);
            label1.Click += new EventHandler(UserControl1_Click);
        }

        
        //private void UserControl1_Hover(object sender, EventArgs e)
        // {
        //     this.BackgroundImage = Properties.Resources.play_hover;
        // }
        //private void UserControl1_Leave(object sender, EventArgs e)
        // {
        //      this.BackgroundImage = Properties.Resources.play;
        //  }
        private void UserControl1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.play_click;
        }

        public bool _3rdParty {
            get { return pictureBox1.Visible; }
            set { pictureBox1.Visible = value; }
        }

        public string text
		{
			get { return label1.Text; }
            set { label1.Text = value; }
		}
    }
    
}
