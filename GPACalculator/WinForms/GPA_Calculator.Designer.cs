namespace GPA_Calculator
{
    partial class GPA_Calculator
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
            HeaderLabel = new Label();
            CalculateGPAButton = new Button();
            CreateCourseButton = new Button();
            CoursesListBox = new ListBox();
            RemoveSelectedButton = new Button();
            CoursesListDropDown = new ComboBox();
            ChooseCourseLabel = new Label();
            ChooseAllCoursesButton = new Button();
            RemoveAllListButton = new Button();
            AddCourseButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.Location = new Point(12, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(230, 45);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "GPA Calculator";
            // 
            // CalculateGPAButton
            // 
            CalculateGPAButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CalculateGPAButton.ForeColor = Color.Black;
            CalculateGPAButton.Location = new Point(403, 357);
            CalculateGPAButton.Name = "CalculateGPAButton";
            CalculateGPAButton.Size = new Size(207, 44);
            CalculateGPAButton.TabIndex = 2;
            CalculateGPAButton.Text = "Calculate GPA";
            CalculateGPAButton.UseVisualStyleBackColor = true;
            CalculateGPAButton.Click += CalculateGPAButton_Click;
            // 
            // CreateCourseButton
            // 
            CreateCourseButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CreateCourseButton.ForeColor = Color.Black;
            CreateCourseButton.Location = new Point(27, 289);
            CreateCourseButton.Name = "CreateCourseButton";
            CreateCourseButton.Size = new Size(249, 44);
            CreateCourseButton.TabIndex = 3;
            CreateCourseButton.Text = "Create New Course";
            CreateCourseButton.UseVisualStyleBackColor = true;
            CreateCourseButton.Click += CreateCourseButton_Click;
            // 
            // CoursesListBox
            // 
            CoursesListBox.BackColor = Color.FromArgb(30, 30, 30);
            CoursesListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CoursesListBox.ForeColor = Color.White;
            CoursesListBox.FormattingEnabled = true;
            CoursesListBox.ItemHeight = 32;
            CoursesListBox.Location = new Point(309, 114);
            CoursesListBox.Name = "CoursesListBox";
            CoursesListBox.Size = new Size(545, 228);
            CoursesListBox.TabIndex = 4;
            // 
            // RemoveSelectedButton
            // 
            RemoveSelectedButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveSelectedButton.ForeColor = Color.Black;
            RemoveSelectedButton.Location = new Point(870, 151);
            RemoveSelectedButton.Name = "RemoveSelectedButton";
            RemoveSelectedButton.Size = new Size(125, 81);
            RemoveSelectedButton.TabIndex = 5;
            RemoveSelectedButton.Text = "Remove Selected";
            RemoveSelectedButton.UseVisualStyleBackColor = true;
            RemoveSelectedButton.Click += RemoveSelectedButton_Click;
            // 
            // CoursesListDropDown
            // 
            CoursesListDropDown.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CoursesListDropDown.FormattingEnabled = true;
            CoursesListDropDown.Location = new Point(27, 143);
            CoursesListDropDown.Name = "CoursesListDropDown";
            CoursesListDropDown.Size = new Size(249, 40);
            CoursesListDropDown.TabIndex = 10;
            // 
            // ChooseCourseLabel
            // 
            ChooseCourseLabel.AutoSize = true;
            ChooseCourseLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ChooseCourseLabel.Location = new Point(27, 94);
            ChooseCourseLabel.Name = "ChooseCourseLabel";
            ChooseCourseLabel.Size = new Size(251, 37);
            ChooseCourseLabel.TabIndex = 11;
            ChooseCourseLabel.Text = "Choose the Courses";
            // 
            // ChooseAllCoursesButton
            // 
            ChooseAllCoursesButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ChooseAllCoursesButton.ForeColor = Color.Black;
            ChooseAllCoursesButton.Location = new Point(27, 239);
            ChooseAllCoursesButton.Name = "ChooseAllCoursesButton";
            ChooseAllCoursesButton.Size = new Size(249, 44);
            ChooseAllCoursesButton.TabIndex = 12;
            ChooseAllCoursesButton.Text = "Add All Courses";
            ChooseAllCoursesButton.UseVisualStyleBackColor = true;
            ChooseAllCoursesButton.Click += ChooseAllCoursesButton_Click;
            // 
            // RemoveAllListButton
            // 
            RemoveAllListButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveAllListButton.ForeColor = Color.Black;
            RemoveAllListButton.Location = new Point(870, 238);
            RemoveAllListButton.Name = "RemoveAllListButton";
            RemoveAllListButton.Size = new Size(125, 81);
            RemoveAllListButton.TabIndex = 13;
            RemoveAllListButton.Text = "Remove All List";
            RemoveAllListButton.UseVisualStyleBackColor = true;
            RemoveAllListButton.Click += RemoveAllListButton_Click;
            // 
            // AddCourseButton
            // 
            AddCourseButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AddCourseButton.ForeColor = Color.Black;
            AddCourseButton.Location = new Point(27, 189);
            AddCourseButton.Name = "AddCourseButton";
            AddCourseButton.Size = new Size(249, 44);
            AddCourseButton.TabIndex = 14;
            AddCourseButton.Text = "Add Course";
            AddCourseButton.UseVisualStyleBackColor = true;
            AddCourseButton.Click += AddCourseButton_Click;
            // 
            // GPA_Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1013, 419);
            Controls.Add(AddCourseButton);
            Controls.Add(RemoveAllListButton);
            Controls.Add(ChooseAllCoursesButton);
            Controls.Add(ChooseCourseLabel);
            Controls.Add(CoursesListDropDown);
            Controls.Add(RemoveSelectedButton);
            Controls.Add(CoursesListBox);
            Controls.Add(CreateCourseButton);
            Controls.Add(CalculateGPAButton);
            Controls.Add(HeaderLabel);
            ForeColor = Color.White;
            MaximizeBox = false;
            MaximumSize = new Size(1029, 458);
            MinimumSize = new Size(1029, 458);
            Name = "GPA_Calculator";
            Text = "FCAI GPA-Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Button CalculateGPAButton;
        private Button CreateCourseButton;
        private ListBox CoursesListBox;
        private Button RemoveSelectedButton;
        private ComboBox CoursesListDropDown;
        private Label ChooseCourseLabel;
        private Button ChooseAllCoursesButton;
        private Button RemoveAllListButton;
        private Button AddCourseButton;
    }
}