using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StateTaxDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void state1_txt_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(state1_txt.Text))
            {
                state2_txt.Enabled = false;
            }
            else
            {
                state2_txt.Enabled = true;
            }
        }

        private void state2_txt_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(state2_txt.Text))
            {
                state3_txt.Enabled = false;
            }
            else
            {
                state3_txt.Enabled = true;
            }
        }

        private void state3_txt_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(state3_txt.Text))
            {
                state4_txt.Enabled = false;
            }
            else
            {
                state4_txt.Enabled = true;
            }
        }

        private void state4_txt_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(state4_txt.Text))
            {
                state5_txt.Enabled = false;
            }
            else
            {
                state5_txt.Enabled = true;
            }
        }

        private void state5_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void compare_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(state1_txt.Text))
            {
                MessageBox.Show("Please enter a state");
            }
            else
            {

            }
        }

        private void fullList_btn_Click(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText(@"C:\Documents\Development\CNN Tax Info\StatesFormattedList");

            MessageBox.Show(sr.ReadToEnd());
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            state1_txt.Text = "";
            state2_txt.Text = "";
            state3_txt.Text = "";
            state4_txt.Text = "";
            state5_txt.Text = "";
        }

    }
}
