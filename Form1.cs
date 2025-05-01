using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

using Facultate.Models;
using Facultate.Services;
using Facultate.Helpers;

namespace Facultate
{
    public partial class Form1 : Form
    {
        private Professor _currentProfessor;
        private int _selectedStudentId;

        private readonly ProfessorService _profService = new ProfessorService();
        private readonly StudentService _studService = new StudentService();

        private void ApplyColor()
        {
            foreach (DataGridViewRow row in StudentsGridView.Rows)
            {
                var dept = row.Cells[nameof(Student.Department)].Value?.ToString();
                if (dept != null)
                    row.DefaultCellStyle.BackColor = ColorHelper.GetColorForDepartment(dept);
            }
        }

        private void LoadStudents()
        {
            var list = _studService.GetByProfessor(_currentProfessor.Id);
            StudentsGridView.DataSource = list;
            ChartHelper.FillPieChart(StudentsDepartamentsChart, list);
            ClearStudentTextBoxes();
            ApplyColor();
            ClearStudentTextBoxes();
        }

        private void LoadStudents(IEnumerable<Student> students)
        {
            var list = students.ToList();
            StudentsGridView.DataSource = list;
            ChartHelper.FillPieChart(StudentsDepartamentsChart, list);
            ClearStudentTextBoxes();
            ApplyColor();
            ClearStudentTextBoxes();
        }

        private void ClearProfessorTextBoxes()
        {
            ProfessorFirstNameBox.Clear();
            ProfessorLastNameBox.Clear();
        }

        private void ClearStudentTextBoxes()
        {
            StudentFirstNameBox.Clear();
            StudentLastNameBox.Clear();
            StudentCNPBox.Clear();
            StudentMatricolNumberBox.Clear();
            StudentSexBox.Clear();
            StudentAgeBox.Clear();
            StudentDepartamentBox.Clear();
            _selectedStudentId = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConnectProfessorButton_Click(object sender, EventArgs e)
        {
            var first = ProfessorFirstNameBox.Text.Trim();
            var last = ProfessorLastNameBox.Text.Trim();

            if (!_profService.Connect(first, last, out var prof, out var err))
            {
                // MessageBox pentru eroare
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ValidationHelper.ValidateName(first, "First name") != null)
                    ProfessorFirstNameBox.Clear();
                if (ValidationHelper.ValidateName(last, "Last name") != null)
                    ProfessorLastNameBox.Clear();
                return;
            }

            _currentProfessor = prof;

            MessageBox.Show($"Connected successfully to Professor {prof.FirstName} {prof.LastName}.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadStudents();
            ClearProfessorTextBoxes();
        }

        private void AddProfessorButton_Click(object sender, EventArgs e)
        {
            var first = ProfessorFirstNameBox.Text.Trim();
            var last = ProfessorLastNameBox.Text.Trim();

            if (!_profService.Add(first, last, out var err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ValidationHelper.ValidateName(first, "First name") != null)
                    ProfessorFirstNameBox.Clear();
                if (ValidationHelper.ValidateName(last, "Last name") != null)
                    ProfessorLastNameBox.Clear();
                return;
            }

            MessageBox.Show("Professor added. Click Connect.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteProfessorButton_Click(object sender, EventArgs e)
        {
            var first = ProfessorFirstNameBox.Text.Trim();
            var last = ProfessorLastNameBox.Text.Trim();

            if (!_profService.Delete(first, last, out var err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Professor and related students deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearProfessorTextBoxes();
        }

        private void ClearProfessorBoxesButton_Click(object sender, EventArgs e)
        {
            ClearProfessorTextBoxes();
        }

        private void RefreshStudentsGridViewButton_Click_1(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void StudentsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (StudentsGridView.CurrentRow == null) return;
            var stud = (Student)StudentsGridView.CurrentRow.DataBoundItem;  // Student class
            _selectedStudentId = stud.Id;

            StudentFirstNameBox.Text = stud.FirstName;
            StudentLastNameBox.Text = stud.LastName;
            StudentCNPBox.Text = stud.CNP;
            StudentMatricolNumberBox.Text = stud.MatricolNumber;
            StudentSexBox.Text = stud.Sex;
            StudentAgeBox.Text = stud.Age.ToString();
            StudentDepartamentBox.Text = stud.Department;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            var dto = new Student
            {
                FirstName = StudentFirstNameBox.Text.Trim(),
                LastName = StudentLastNameBox.Text.Trim(),
                CNP = StudentCNPBox.Text.Trim(),
                MatricolNumber = StudentMatricolNumberBox.Text.Trim(),
                Sex = StudentSexBox.Text.Trim(),
                Department = StudentDepartamentBox.Text.Trim(),
                Age = int.TryParse(StudentAgeBox.Text, out var a) ? a : 0
            };

            if (!_studService.Add(_currentProfessor.Id, dto, out var err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ValidationHelper.ValidateName(dto.FirstName, "First name") != null)
                    StudentFirstNameBox.Clear();
                if (ValidationHelper.ValidateName(dto.LastName, "Last name") != null)
                    StudentLastNameBox.Clear();
                if (ValidationHelper.ValidateCNP(dto.CNP) != null)
                    StudentCNPBox.Clear();
                if (ValidationHelper.ValidateMatricol(dto.MatricolNumber) != null)
                    StudentMatricolNumberBox.Clear();
                if (ValidationHelper.ValidateSex(dto.Sex) != null)
                    StudentSexBox.Clear();
                if (ValidationHelper.ValidateAge(dto.Age) != null)
                    StudentAgeBox.Clear();
                if (ValidationHelper.ValidateDepartment(dto.Department) != null)
                    StudentDepartamentBox.Clear();
                return;
            }

            LoadStudents();
            ClearProfessorTextBoxes();
        }

        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {
            if (_selectedStudentId == 0)
            {
                MessageBox.Show("Choose a student first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new Student
            {
                FirstName = StudentFirstNameBox.Text.Trim(),
                LastName = StudentLastNameBox.Text.Trim(),
                CNP = StudentCNPBox.Text.Trim(),
                MatricolNumber = StudentMatricolNumberBox.Text.Trim(),
                Sex = StudentSexBox.Text.Trim(),
                Department = StudentDepartamentBox.Text.Trim(),
                Age = int.TryParse(StudentAgeBox.Text, out var a2) ? a2 : 0
            };

            if (!_studService.Update(_selectedStudentId, dto, out var err2))
            {
                MessageBox.Show(err2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadStudents();
            ClearStudentTextBoxes();
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            if (!_studService.Delete(_selectedStudentId, out var err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadStudents();
            ClearStudentTextBoxes();
        }

        private void ClearStudentBoxesButton_Click(object sender, EventArgs e)
        {
            ClearStudentTextBoxes();
        }

        private void FilterStudentButton_Click(object sender, EventArgs e)
        {
            var crit = new Student
            {
                FirstName = StudentFirstNameBox.Text.Trim(),
                LastName = StudentLastNameBox.Text.Trim(),
                CNP = StudentCNPBox.Text.Trim(),
                MatricolNumber = StudentMatricolNumberBox.Text.Trim(),
                Sex = StudentSexBox.Text.Trim(),
                Department = StudentDepartamentBox.Text.Trim(),
                Age = int.TryParse(StudentAgeBox.Text, out var a) ? a : 0
            };
            // Validate criteria using helper
            var err = ValidationHelper.ValidateFilterCriteria(crit);
            if (err != null)
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // clear invalid fields
                if (ValidationHelper.ValidateName(crit.FirstName, "First name") != null)
                    StudentFirstNameBox.Clear();
                if (ValidationHelper.ValidateName(crit.LastName, "Last name") != null)
                    StudentLastNameBox.Clear();
                if (ValidationHelper.ValidateCNP(crit.CNP) != null)
                    StudentCNPBox.Clear();
                if (ValidationHelper.ValidateMatricol(crit.MatricolNumber) != null)
                    StudentMatricolNumberBox.Clear();
                if (ValidationHelper.ValidateSex(crit.Sex) != null)
                    StudentSexBox.Clear();
                if (ValidationHelper.ValidateDepartment(crit.Department) != null)
                    StudentDepartamentBox.Clear();
                if (crit.Age != 0 && ValidationHelper.ValidateAge(crit.Age) != null)
                    StudentAgeBox.Clear();
                return;
            }
            // Delegate filtering to service
            var filtered = _studService.Filter(_currentProfessor.Id, crit);
            LoadStudents(filtered);
        }

        private void SortFirstNameStudentButton_Click(object sender, EventArgs e)
        {
            var sorted = _studService.SortByFirstName(_currentProfessor.Id);
            LoadStudents(sorted);
        }

        private void SortLastNameStudentButton_Click(object sender, EventArgs e)
        {
            var sorted = _studService.SortByLastName(_currentProfessor.Id);
            LoadStudents(sorted);
        }
    }
}
