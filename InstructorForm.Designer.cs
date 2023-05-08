namespace ExaminationSystem
{
    partial class InstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.InstUserName = new System.Windows.Forms.Label();
            this.InstaName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btn_ShowResult = new System.Windows.Forms.Button();
            this.btn_AssignStd = new System.Windows.Forms.Button();
            this.btn_MakeExam = new System.Windows.Forms.Button();
            this.btn_AddQuestion = new System.Windows.Forms.Button();
            this.Ex_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.InstUserName);
            this.panel1.Controls.Add(this.InstaName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btn_ShowResult);
            this.panel1.Controls.Add(this.btn_AssignStd);
            this.panel1.Controls.Add(this.btn_MakeExam);
            this.panel1.Controls.Add(this.btn_AddQuestion);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 566);
            this.panel1.TabIndex = 0;
            // 
            // InstUserName
            // 
            this.InstUserName.AutoSize = true;
            this.InstUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstUserName.Location = new System.Drawing.Point(94, 52);
            this.InstUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstUserName.Name = "InstUserName";
            this.InstUserName.Size = new System.Drawing.Size(0, 20);
            this.InstUserName.TabIndex = 12;
            // 
            // InstaName
            // 
            this.InstaName.AutoSize = true;
            this.InstaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstaName.Location = new System.Drawing.Point(94, 16);
            this.InstaName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstaName.Name = "InstaName";
            this.InstaName.Size = new System.Drawing.Size(0, 20);
            this.InstaName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Instructor:";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = global::ExaminationSytem.Properties.Resources.power_off__2_;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(22, 511);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(154, 44);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btn_ShowResult
            // 
            this.btn_ShowResult.BackColor = System.Drawing.Color.White;
            this.btn_ShowResult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ShowResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btn_ShowResult.Location = new System.Drawing.Point(0, 335);
            this.btn_ShowResult.Name = "btn_ShowResult";
            this.btn_ShowResult.Size = new System.Drawing.Size(197, 38);
            this.btn_ShowResult.TabIndex = 3;
            this.btn_ShowResult.Text = "Show Result";
            this.btn_ShowResult.UseVisualStyleBackColor = false;
            this.btn_ShowResult.Click += new System.EventHandler(this.btn_ShowResult_Click);
            // 
            // btn_AssignStd
            // 
            this.btn_AssignStd.BackColor = System.Drawing.Color.White;
            this.btn_AssignStd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_AssignStd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btn_AssignStd.Location = new System.Drawing.Point(-1, 291);
            this.btn_AssignStd.Name = "btn_AssignStd";
            this.btn_AssignStd.Size = new System.Drawing.Size(197, 38);
            this.btn_AssignStd.TabIndex = 2;
            this.btn_AssignStd.Text = "Assign Students";
            this.btn_AssignStd.UseVisualStyleBackColor = false;
            this.btn_AssignStd.Click += new System.EventHandler(this.btn_AssignStd_Click);
            // 
            // btn_MakeExam
            // 
            this.btn_MakeExam.BackColor = System.Drawing.Color.White;
            this.btn_MakeExam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_MakeExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btn_MakeExam.Location = new System.Drawing.Point(0, 246);
            this.btn_MakeExam.Name = "btn_MakeExam";
            this.btn_MakeExam.Size = new System.Drawing.Size(197, 38);
            this.btn_MakeExam.TabIndex = 1;
            this.btn_MakeExam.Text = "Make Exam";
            this.btn_MakeExam.UseVisualStyleBackColor = false;
            this.btn_MakeExam.Click += new System.EventHandler(this.btn_MakeExam_Click);
            // 
            // btn_AddQuestion
            // 
            this.btn_AddQuestion.BackColor = System.Drawing.Color.White;
            this.btn_AddQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btn_AddQuestion.Location = new System.Drawing.Point(0, 201);
            this.btn_AddQuestion.Name = "btn_AddQuestion";
            this.btn_AddQuestion.Size = new System.Drawing.Size(197, 38);
            this.btn_AddQuestion.TabIndex = 0;
            this.btn_AddQuestion.Text = "Add Question";
            this.btn_AddQuestion.UseVisualStyleBackColor = false;
            this.btn_AddQuestion.Click += new System.EventHandler(this.btn_AddQuestion_Click);
            // 
            // Ex_label
            // 
            this.Ex_label.AutoSize = true;
            this.Ex_label.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex_label.Location = new System.Drawing.Point(354, 54);
            this.Ex_label.Name = "Ex_label";
            this.Ex_label.Size = new System.Drawing.Size(315, 35);
            this.Ex_label.TabIndex = 1;
            this.Ex_label.Text = "Examination System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 566);
            this.panel2.TabIndex = 3;
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ex_label);
            this.Controls.Add(this.panel1);
            this.Name = "InstructorForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AssignStd;
        private System.Windows.Forms.Button btn_MakeExam;
        private System.Windows.Forms.Button btn_AddQuestion;
        private System.Windows.Forms.Button btn_ShowResult;
        private System.Windows.Forms.Label Ex_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label InstUserName;
        private System.Windows.Forms.Label InstaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}

