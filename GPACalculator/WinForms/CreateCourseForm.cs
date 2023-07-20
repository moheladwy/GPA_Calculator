using GPA_Calculator_Library;
using GPA_Calculator_Library.Connectors;
using GPA_Calculator_Library.Models;

namespace GPA_Calculator
{
    public partial class CreateCourseForm : Form
    {
        private List<int> CreditHoursList = new();
        private List<string> GradesList = new();
        ICourseRequestor CallingForm;

        public CreateCourseForm(ICourseRequestor requestor)
        {
            InitializeComponent();
            CallingForm = requestor;
            InitializeLists();
            WireUpLists();
        }

        private void InitializeLists()
        {
            for (int i = 0; i < 4; i++)
                CreditHoursList.Add(i);

            GradesList.Add(GradesProcessor.ToString(Grades.APlus));
            GradesList.Add(GradesProcessor.ToString(Grades.A));
            GradesList.Add(GradesProcessor.ToString(Grades.BPlus));
            GradesList.Add(GradesProcessor.ToString(Grades.B));
            GradesList.Add(GradesProcessor.ToString(Grades.CPlus));
            GradesList.Add(GradesProcessor.ToString(Grades.C));
            GradesList.Add(GradesProcessor.ToString(Grades.DPlus));
            GradesList.Add(GradesProcessor.ToString(Grades.D));
            GradesList.Add(GradesProcessor.ToString(Grades.F));
        }

        private void WireUpLists()
        {
            CreditHoursDropDown.DataSource = null;
            CreditHoursDropDown.DataSource = CreditHoursList;

            GradeDropDown.DataSource = null;
            GradeDropDown.DataSource = GradesList;
        }

        private void CreateCourseButton_Click(object sender, EventArgs e)
        {
            if (CourseNameValue.Text.Length == 0 || CourseNameValue.Text.Length >= 250)
            {
                MessageBox.Show("Course Name cannot be empty or more than 250 characters!",
                    "Create Course Error Message");
                return;
            }

            CourseModel model = new();
            model.CourseName = CourseNameValue.Text;
            model.CreditHours = (int)CreditHoursDropDown.SelectedItem;
            model.Grade = (string)GradeDropDown.SelectedItem;

            GlobalConfig.connection.CreateCourse(model);
            CallingForm.CourseComplete(model);
            
            Close();
        }
    }
}
