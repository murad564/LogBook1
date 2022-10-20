namespace LogBookApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_groupName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbutton_subsituteTeacher = new System.Windows.Forms.RadioButton();
            this.rbutton_regularTeacher = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_groupName
            // 
            this.lbl_groupName.AutoSize = true;
            this.lbl_groupName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_groupName.Location = new System.Drawing.Point(3, 12);
            this.lbl_groupName.Name = "lbl_groupName";
            this.lbl_groupName.Size = new System.Drawing.Size(102, 32);
            this.lbl_groupName.TabIndex = 0;
            this.lbl_groupName.Text = "logbook";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbutton_subsituteTeacher);
            this.panel1.Controls.Add(this.rbutton_regularTeacher);
            this.panel1.Controls.Add(this.lbl_groupName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 139);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1044, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(1022, 113);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(85, 23);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Add Button";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(842, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(738, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 60);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(738, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dərs mövzusu";
            // 
            // rbutton_subsituteTeacher
            // 
            this.rbutton_subsituteTeacher.AutoSize = true;
            this.rbutton_subsituteTeacher.Location = new System.Drawing.Point(122, 50);
            this.rbutton_subsituteTeacher.Name = "rbutton_subsituteTeacher";
            this.rbutton_subsituteTeacher.Size = new System.Drawing.Size(123, 19);
            this.rbutton_subsituteTeacher.TabIndex = 2;
            this.rbutton_subsituteTeacher.TabStop = true;
            this.rbutton_subsituteTeacher.Text = "Əvəzedici Müəllim";
            this.rbutton_subsituteTeacher.UseVisualStyleBackColor = true;
            this.rbutton_subsituteTeacher.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbutton_regularTeacher
            // 
            this.rbutton_regularTeacher.AutoSize = true;
            this.rbutton_regularTeacher.Location = new System.Drawing.Point(8, 50);
            this.rbutton_regularTeacher.Name = "rbutton_regularTeacher";
            this.rbutton_regularTeacher.Size = new System.Drawing.Size(90, 19);
            this.rbutton_regularTeacher.TabIndex = 1;
            this.rbutton_regularTeacher.TabStop = true;
            this.rbutton_regularTeacher.Text = "Adi Müəllim";
            this.rbutton_regularTeacher.UseVisualStyleBackColor = true;
            this.rbutton_regularTeacher.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(12, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1122, 381);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1146, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_groupName;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Label label1;
        private RadioButton rbutton_subsituteTeacher;
        private RadioButton rbutton_regularTeacher;
        private Button button_add;
        private Panel panel3;
        private Button button1;
    }
}