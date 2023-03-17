using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            updateDataSourceForListBox();
            updateCourseButton.Enabled = false;

        }

        private void updateDataSourceForListBox()
        {
            using (var database = new Database1MdfContext())
            {
                List<Course> courses;
                if (courseFilter.Text.IsNullOrEmpty())
                {
                    courses = database.Courses.ToList();
                }
                else
                {
                    courses = database.Courses.ToList().Where(c => c.FullDescription.Contains(courseFilter.Text)).ToList();
                }


                courseListBox.DataSource = courses;
                courseListBox.DisplayMember = "FullDescription";
                courseListBox.ClearSelected();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            using (var database = new Database1MdfContext())
            {
                foreach (var course in database.Courses)
                {
                    label1.Text += $"{course}" + Environment.NewLine;
                }

            }

        }

        // chat gpt
        // "how do you bind an entity framework core table to a list box in .net core forms"
        // "how do i handle clicking on an item in the list box"

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            // TODO - check for valid input
            Course course = new Course()
            {
                Name = nameTextBox.Text,
                Number = numberTextBox.Text,
                Department = departmentTextBox.Text
            };

            using (var database = new Database1MdfContext())
            {
                if (database.Courses.Any(c => c.Name == course.Name && c.Number == course.Number && c.Department == course.Department))
                {
                    label1.Text = "Duplicate course found! Try again!";
                    return;
                }


                database.Courses.Add(course);
                // the nice thing to do is to use async not lock the UI
                database.SaveChanges();
                nameTextBox.Text = "";
                numberTextBox.Text = "";
                departmentTextBox.Text = "";
            }

            updateDataSourceForListBox();
        }

        private void courseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseListBox.SelectedItem != null)
            {
                Course selectedCourse = (Course)courseListBox.SelectedItem;
                nameTextBox.Text = selectedCourse.Name;
                numberTextBox.Text = selectedCourse.Number;
                departmentTextBox.Text = selectedCourse.Department;
                updateCourseButton.Enabled = true;
            }
        }

        private void updateCourseButton_Click(object sender, EventArgs e)
        {
            if (courseListBox.SelectedItem != null)
            {
                Course selectedCourse = (Course)courseListBox.SelectedItem;

                selectedCourse.Name = nameTextBox.Text;
                selectedCourse.Department = departmentTextBox.Text;
                selectedCourse.Number = numberTextBox.Text;

                using (var database = new Database1MdfContext())
                {
                    database.Courses.Update(selectedCourse);
                    database.SaveChanges();
                }

                updateCourseButton.Enabled = false;
                courseListBox.ClearSelected();
                updateDataSourceForListBox();
            }
        }

        private void courseFilter_TextChanged(object sender, EventArgs e)
        {
            updateDataSourceForListBox();
        }
    }
}