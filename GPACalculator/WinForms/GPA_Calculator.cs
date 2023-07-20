using GPA_Calculator_Library;
using GPA_Calculator_Library.Connectors;
using GPA_Calculator_Library.Models;

namespace GPA_Calculator
{
    public partial class GPA_Calculator : Form, ICourseRequestor
    {
        List<CourseModel> Courses = GlobalConfig.connection.GetCourse_All();
        List<CourseModel> SelectedCourses = new();

        public GPA_Calculator()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            CoursesListDropDown.DataSource = null;
            CoursesListDropDown.DataSource = Courses;
            CoursesListDropDown.DisplayMember = "CourseName";

            CoursesListBox.DataSource = null;
            CoursesListBox.DataSource = SelectedCourses;
            CoursesListBox.DisplayMember = "CourseName";
        }

        public void CourseComplete(CourseModel model)
        {
            SelectedCourses.Add(model);
            WireUpLists();
        }

        private void CreateCourseButton_Click(object sender, EventArgs e)
        {
            new CreateCourseForm(this).Show();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            if (Courses.Count == 0)
            {
                MessageBox.Show("The List is Empty!", "Add Course Error Message");
                return;
            }
            CourseModel model = (CourseModel)CoursesListDropDown.SelectedItem;

            Courses.Remove(model);
            SelectedCourses.Add(model);

            WireUpLists();
        }

        private void ChooseAllCoursesButton_Click(object sender, EventArgs e)
        {
            if (Courses.Count == 0)
            {
                MessageBox.Show("The List is Empty!", "Choose All Courses Error Message");
                return;
            }

            foreach (CourseModel model in Courses)
                SelectedCourses.Add(model);
            Courses.Clear();

            WireUpLists();
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            CourseModel model = (CourseModel)CoursesListBox.SelectedItem;
            if (SelectedCourses.Count == 0)
            {
                MessageBox.Show("The List is Empty!", "Remove Course Error Message");
                return;
            }
            if (model == null)
            {
                MessageBox.Show("You have to select one course to remove it!",
                    "Remove Course Error Message");
                return;
            }
            SelectedCourses.Remove(model);
            Courses.Add(model);

            WireUpLists();
        }

        private void RemoveAllListButton_Click(object sender, EventArgs e)
        {
            if (SelectedCourses.Count == 0)
            {
                MessageBox.Show("The List is Empty!", "Remove Course Error Message");
                return;
            }

            foreach (CourseModel model in SelectedCourses)
                Courses.Add(model);
            SelectedCourses.Clear();

            WireUpLists();
        }

        private void CalculateGPAButton_Click(object sender, EventArgs e)
        {
            if (SelectedCourses.Count == 0)
            {
                MessageBox.Show("You have to choose courses at first!", "Calculate GPA Error Message");
                return;
            }
            double bast = 0, maqam = 0;

            foreach (CourseModel model in SelectedCourses)
            {
                bast += (model.CreditHours * GradesProcessor.GetGPA(model.Grade));
                maqam += model.CreditHours;
            }

            double GPA = bast / maqam;
            MessageBox.Show($"Your total GPA for the selected courses is {GPA.ToString("#.##")}", "FCAI GPA Calculator");
        }
    }
}
