namespace GPA_Calculator
{
    partial class CreateCourseForm
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
            CourseNameValue = new TextBox();
            CourseNameLabel = new Label();
            CreditHoursLabel = new Label();
            GradeLabel = new Label();
            CreateCourseButton = new Button();
            GradeDropDown = new ComboBox();
            CreditHoursDropDown = new ComboBox();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.Location = new Point(12, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(196, 40);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Create Course";
            // 
            // CourseNameValue
            // 
            CourseNameValue.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CourseNameValue.Location = new Point(199, 84);
            CourseNameValue.Multiline = true;
            CourseNameValue.Name = "CourseNameValue";
            CourseNameValue.PlaceholderText = "Math 2";
            CourseNameValue.Size = new Size(227, 38);
            CourseNameValue.TabIndex = 1;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CourseNameLabel.Location = new Point(24, 84);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(159, 32);
            CourseNameLabel.TabIndex = 2;
            CourseNameLabel.Text = "Course Name";
            // 
            // CreditHoursLabel
            // 
            CreditHoursLabel.AutoSize = true;
            CreditHoursLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CreditHoursLabel.Location = new Point(24, 144);
            CreditHoursLabel.Name = "CreditHoursLabel";
            CreditHoursLabel.Size = new Size(148, 32);
            CreditHoursLabel.TabIndex = 4;
            CreditHoursLabel.Text = "Credit Hours";
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GradeLabel.Location = new Point(24, 203);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(77, 32);
            GradeLabel.TabIndex = 6;
            GradeLabel.Text = "Grade";
            // 
            // CreateCourseButton
            // 
            CreateCourseButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CreateCourseButton.ForeColor = Color.Black;
            CreateCourseButton.Location = new Point(129, 269);
            CreateCourseButton.Name = "CreateCourseButton";
            CreateCourseButton.Size = new Size(202, 48);
            CreateCourseButton.TabIndex = 7;
            CreateCourseButton.Text = "Create Course";
            CreateCourseButton.UseVisualStyleBackColor = true;
            CreateCourseButton.Click += CreateCourseButton_Click;
            // 
            // GradeDropDown
            // 
            GradeDropDown.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GradeDropDown.FormattingEnabled = true;
            GradeDropDown.Location = new Point(199, 202);
            GradeDropDown.Name = "GradeDropDown";
            GradeDropDown.Size = new Size(227, 40);
            GradeDropDown.TabIndex = 8;
            // 
            // CreditHoursDropDown
            // 
            CreditHoursDropDown.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CreditHoursDropDown.FormattingEnabled = true;
            CreditHoursDropDown.Location = new Point(199, 144);
            CreditHoursDropDown.Name = "CreditHoursDropDown";
            CreditHoursDropDown.Size = new Size(227, 40);
            CreditHoursDropDown.TabIndex = 9;
            // 
            // CreateCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(444, 348);
            Controls.Add(CreditHoursDropDown);
            Controls.Add(GradeDropDown);
            Controls.Add(CreateCourseButton);
            Controls.Add(GradeLabel);
            Controls.Add(CreditHoursLabel);
            Controls.Add(CourseNameLabel);
            Controls.Add(CourseNameValue);
            Controls.Add(HeaderLabel);
            ForeColor = Color.White;
            MaximizeBox = false;
            MaximumSize = new Size(460, 387);
            MinimumSize = new Size(460, 387);
            Name = "CreateCourseForm";
            Text = "Create Course";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private TextBox CourseNameValue;
        private Label CourseNameLabel;
        private Label CreditHoursLabel;
        private Label GradeLabel;
        private Button CreateCourseButton;
        private ComboBox GradeDropDown;
        private ComboBox CreditHoursDropDown;
    }
}