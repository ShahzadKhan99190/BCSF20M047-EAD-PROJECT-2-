namespace Student_Interests_Sys_Project
{
    partial class StudentList_Form
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
            dataGridView = new DataGridView();
            btnPrevious = new Button();
            btnNext = new Button();
            lblPageNumber = new Label();
            label1 = new Label();
            Dashboard_Btn = new Button();
            Add_Btn = new Button();
            ID_textbox = new TextBox();
            label2 = new Label();
            Edit_Btn = new Button();
            Delete_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(46, 197);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(716, 267);
            dataGridView.TabIndex = 0;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(590, 168);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(50, 23);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(712, 168);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(50, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(656, 168);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(38, 15);
            lblPageNumber.TabIndex = 3;
            lblPageNumber.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 18);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 4;
            label1.Text = "Student Interests System";
            // 
            // Dashboard_Btn
            // 
            Dashboard_Btn.Location = new Point(46, 46);
            Dashboard_Btn.Name = "Dashboard_Btn";
            Dashboard_Btn.Size = new Size(86, 23);
            Dashboard_Btn.TabIndex = 5;
            Dashboard_Btn.Text = "Dashboard";
            Dashboard_Btn.UseVisualStyleBackColor = true;
            Dashboard_Btn.Click += Dashboard_Btn_Click;
            // 
            // Add_Btn
            // 
            Add_Btn.Location = new Point(138, 46);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(81, 23);
            Add_Btn.TabIndex = 6;
            Add_Btn.Text = "Add Student";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // ID_textbox
            // 
            ID_textbox.Location = new Point(151, 118);
            ID_textbox.Name = "ID_textbox";
            ID_textbox.Size = new Size(68, 23);
            ID_textbox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 121);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 8;
            label2.Text = "Enter Studeny ID:";
            // 
            // Edit_Btn
            // 
            Edit_Btn.Location = new Point(126, 147);
            Edit_Btn.Name = "Edit_Btn";
            Edit_Btn.Size = new Size(56, 23);
            Edit_Btn.TabIndex = 9;
            Edit_Btn.Text = "Edit";
            Edit_Btn.UseVisualStyleBackColor = true;
            Edit_Btn.Click += Edit_Btn_Click;
            // 
            // Delete_Btn
            // 
            Delete_Btn.Location = new Point(188, 147);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.Size = new Size(56, 23);
            Delete_Btn.TabIndex = 10;
            Delete_Btn.Text = "Delete";
            Delete_Btn.UseVisualStyleBackColor = true;
            // 
            // StudentList_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 476);
            Controls.Add(Delete_Btn);
            Controls.Add(Edit_Btn);
            Controls.Add(label2);
            Controls.Add(ID_textbox);
            Controls.Add(Add_Btn);
            Controls.Add(Dashboard_Btn);
            Controls.Add(label1);
            Controls.Add(lblPageNumber);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(dataGridView);
            Name = "StudentList_Form";
            Text = "StudentList_Form";
            Load += StudentList_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblPageNumber;
        private Label label1;
        private Button Dashboard_Btn;
        private Button Add_Btn;
        private TextBox ID_textbox;
        private Label label2;
        private Button Edit_Btn;
        private Button Delete_Btn;
    }
}