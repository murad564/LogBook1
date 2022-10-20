using LogBookApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBookApp.UserControls
{
    public partial class UCStudent : UserControl
    {
        public ParticipationStatus Status;
        byte diamond;
        public UCStudent()
        {
            InitializeComponent();
        }

        public void CheckButton(Button button)
        {
            if (button == button1)
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                diamond = 1;
            }
            else if (button == button2)
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
                button3.BackColor = Color.Red;
                diamond = 2;
            }
            else if (button == button3)
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
                button3.BackColor = Color.Blue;
                diamond = 3;
            }
            else
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                diamond = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckButton(sender as Button);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly)
                textBox1.ReadOnly = false;
            textBox1.Visible = true;
            btn_delete.Visible = true;
            btn_ok.Visible = true;
            btn_comment.Visible = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.Visible = false;
            btn_delete.Visible = false;
            btn_ok.Visible = false;
            btn_comment.Visible = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            btn_delete.Visible = false;
            btn_ok.Visible = false;
            btn_comment.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                Status = ParticipationStatus.Present;
            else if (radioButton2.Checked)
                Status = ParticipationStatus.Late;
            else if (radioButton3.Checked)
                Status = ParticipationStatus.Absent;
            else Status = ParticipationStatus.Unknown;
        }

        public Student LoadStudent()
        {
            Student student = new(int.Parse(lbl_no.Text), "", lbl_fullname.Text, lbl_fullname.Text, lbl_fullname.Text, DateTime.Parse(lbl_lastIn.Text), Status, byte.Parse(cbox_test.Text), byte.Parse(cbox_classWork.Text), diamond, textBox1.Text);

            return student;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbox_classWork_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbox_test_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_lastIn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbox_pp_Click(object sender, EventArgs e)
        {

        }

        private void lbl_fullname_Click(object sender, EventArgs e)
        {

        }

        private void lbl_no_Click(object sender, EventArgs e)
        {

        }
    }
}