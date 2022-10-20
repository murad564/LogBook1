using LogBookApp.Models;
using LogBookApp.Repository;
using LogBookApp.UserControls;
using System.Text.Json;

namespace LogBookApp
{
    public partial class Form1 : Form
    {
        bool editButtonActive = false;
        public Form1()
        {
            InitializeComponent();
            rbutton_regularTeacher.Checked = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbutton_regularTeacher.Checked || rbutton_subsituteTeacher.Checked)
                editButtonActive = true;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox1.ReadOnly)
                textBox1.ReadOnly = false;
            else if (editButtonActive)
                textBox1.Visible = true;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            panel3.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var students = FakeRepos.GetStudents();
            for (int i = students.Count - 1; i >= 0; i--)
            {
                UCStudent uc = new UCStudent();

                uc.lbl_no.Text = students[i].Number.ToString();
                uc.lbl_fullname.Text = students[i].FullName();
                uc.lbl_lastIn.Text = students[i].LastIn.ToString();
                //uc.radioButton1.Text = student.Number.ToString();
                //uc.radioButton2.Text = student.Number.ToString();
                //uc.radioButton3.Text = student.Number.ToString();
                uc.Dock = DockStyle.Top;
                panel3.Controls.Add(uc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Student> students = new();
            foreach (var item in panel3.Controls)
            {
                students.Add((item as UCStudent).LoadStudent());
            }
            string jsonString = JsonSerializer.Serialize(students);
            File.WriteAllText("students.json", jsonString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_groupName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}