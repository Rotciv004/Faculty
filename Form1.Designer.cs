namespace Facultate
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl1 = new TabControl();
            ConnectionPage = new TabPage();
            ClearProfessorBoxesButton = new Button();
            DeleteProfessorButton = new Button();
            AddProfessorButton = new Button();
            ConnectProfessorButton = new Button();
            label2 = new Label();
            ProfessorLastNameBox = new TextBox();
            label1 = new Label();
            titleConnectionPage = new Label();
            ProfessorFirstNameBox = new TextBox();
            tabPage2 = new TabPage();
            StudentsDepartamentsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            RefreshStudentsGridViewButton = new Button();
            ClearStudentBoxesButton = new Button();
            SortFirstNameStudentButton = new Button();
            FilterStudentButton = new Button();
            UpdateStudentButton = new Button();
            DeleteStudentButton = new Button();
            AddStudentButton = new Button();
            label10 = new Label();
            StudentDepartamentBox = new TextBox();
            label9 = new Label();
            StudentAgeBox = new TextBox();
            label8 = new Label();
            StudentMatricolNumberBox = new TextBox();
            label7 = new Label();
            StudentSexBox = new TextBox();
            label6 = new Label();
            StudentCNPBox = new TextBox();
            label5 = new Label();
            StudentLastNameBox = new TextBox();
            label4 = new Label();
            StudentFirstNameBox = new TextBox();
            StudentsGridView = new DataGridView();
            label3 = new Label();
            SortLastNameStudentButton = new Button();
            tabControl1.SuspendLayout();
            ConnectionPage.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentsDepartamentsChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentsGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ConnectionPage);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2251, 1875);
            tabControl1.TabIndex = 0;
            // 
            // ConnectionPage
            // 
            ConnectionPage.BackColor = Color.LightBlue;
            ConnectionPage.Controls.Add(ClearProfessorBoxesButton);
            ConnectionPage.Controls.Add(DeleteProfessorButton);
            ConnectionPage.Controls.Add(AddProfessorButton);
            ConnectionPage.Controls.Add(ConnectProfessorButton);
            ConnectionPage.Controls.Add(label2);
            ConnectionPage.Controls.Add(ProfessorLastNameBox);
            ConnectionPage.Controls.Add(label1);
            ConnectionPage.Controls.Add(titleConnectionPage);
            ConnectionPage.Controls.Add(ProfessorFirstNameBox);
            ConnectionPage.Location = new Point(8, 46);
            ConnectionPage.Name = "ConnectionPage";
            ConnectionPage.Padding = new Padding(3);
            ConnectionPage.Size = new Size(2235, 1821);
            ConnectionPage.TabIndex = 0;
            ConnectionPage.Text = "Connection page";
            // 
            // ClearProfessorBoxesButton
            // 
            ClearProfessorBoxesButton.Location = new Point(324, 369);
            ClearProfessorBoxesButton.Name = "ClearProfessorBoxesButton";
            ClearProfessorBoxesButton.Size = new Size(150, 46);
            ClearProfessorBoxesButton.TabIndex = 8;
            ClearProfessorBoxesButton.Text = "CLEAR";
            ClearProfessorBoxesButton.UseVisualStyleBackColor = true;
            ClearProfessorBoxesButton.Click += ClearProfessorBoxesButton_Click;
            // 
            // DeleteProfessorButton
            // 
            DeleteProfessorButton.Location = new Point(637, 432);
            DeleteProfessorButton.Name = "DeleteProfessorButton";
            DeleteProfessorButton.Size = new Size(150, 46);
            DeleteProfessorButton.TabIndex = 7;
            DeleteProfessorButton.Text = "DELETE";
            DeleteProfessorButton.UseVisualStyleBackColor = true;
            DeleteProfessorButton.Click += DeleteProfessorButton_Click;
            // 
            // AddProfessorButton
            // 
            AddProfessorButton.Location = new Point(637, 369);
            AddProfessorButton.Name = "AddProfessorButton";
            AddProfessorButton.Size = new Size(150, 46);
            AddProfessorButton.TabIndex = 6;
            AddProfessorButton.Text = "ADD";
            AddProfessorButton.UseVisualStyleBackColor = true;
            AddProfessorButton.Click += AddProfessorButton_Click;
            // 
            // ConnectProfessorButton
            // 
            ConnectProfessorButton.Location = new Point(30, 369);
            ConnectProfessorButton.Name = "ConnectProfessorButton";
            ConnectProfessorButton.Size = new Size(150, 46);
            ConnectProfessorButton.TabIndex = 5;
            ConnectProfessorButton.Text = "CONNECT";
            ConnectProfessorButton.UseVisualStyleBackColor = true;
            ConnectProfessorButton.Click += ConnectProfessorButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 234);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 4;
            label2.Text = "Last name";
            // 
            // ProfessorLastNameBox
            // 
            ProfessorLastNameBox.Location = new Point(30, 269);
            ProfessorLastNameBox.Name = "ProfessorLastNameBox";
            ProfessorLastNameBox.Size = new Size(757, 39);
            ProfessorLastNameBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 140);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 2;
            label1.Text = "First name";
            // 
            // titleConnectionPage
            // 
            titleConnectionPage.AutoSize = true;
            titleConnectionPage.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleConnectionPage.Location = new Point(30, 22);
            titleConnectionPage.Name = "titleConnectionPage";
            titleConnectionPage.Size = new Size(784, 50);
            titleConnectionPage.TabIndex = 1;
            titleConnectionPage.Text = "Connect to a Professor or add a new Professor";
            // 
            // ProfessorFirstNameBox
            // 
            ProfessorFirstNameBox.Location = new Point(30, 175);
            ProfessorFirstNameBox.Name = "ProfessorFirstNameBox";
            ProfessorFirstNameBox.Size = new Size(757, 39);
            ProfessorFirstNameBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightBlue;
            tabPage2.Controls.Add(SortLastNameStudentButton);
            tabPage2.Controls.Add(StudentsDepartamentsChart);
            tabPage2.Controls.Add(RefreshStudentsGridViewButton);
            tabPage2.Controls.Add(ClearStudentBoxesButton);
            tabPage2.Controls.Add(SortFirstNameStudentButton);
            tabPage2.Controls.Add(FilterStudentButton);
            tabPage2.Controls.Add(UpdateStudentButton);
            tabPage2.Controls.Add(DeleteStudentButton);
            tabPage2.Controls.Add(AddStudentButton);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(StudentDepartamentBox);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(StudentAgeBox);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(StudentMatricolNumberBox);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(StudentSexBox);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(StudentCNPBox);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(StudentLastNameBox);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(StudentFirstNameBox);
            tabPage2.Controls.Add(StudentsGridView);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(2235, 1821);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Students page";
            // 
            // StudentsDepartamentsChart
            // 
            StudentsDepartamentsChart.BackColor = Color.LightBlue;
            chartArea2.Name = "ChartArea1";
            StudentsDepartamentsChart.ChartAreas.Add(chartArea2);
            StudentsDepartamentsChart.Cursor = Cursors.SizeAll;
            legend2.Name = "Legend1";
            StudentsDepartamentsChart.Legends.Add(legend2);
            StudentsDepartamentsChart.Location = new Point(32, 1064);
            StudentsDepartamentsChart.Name = "StudentsDepartamentsChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            StudentsDepartamentsChart.Series.Add(series2);
            StudentsDepartamentsChart.Size = new Size(2170, 695);
            StudentsDepartamentsChart.TabIndex = 25;
            StudentsDepartamentsChart.Text = "Departaments Chart";
            // 
            // RefreshStudentsGridViewButton
            // 
            RefreshStudentsGridViewButton.Location = new Point(344, 892);
            RefreshStudentsGridViewButton.Name = "RefreshStudentsGridViewButton";
            RefreshStudentsGridViewButton.Size = new Size(150, 46);
            RefreshStudentsGridViewButton.TabIndex = 24;
            RefreshStudentsGridViewButton.Text = "REFRESH";
            RefreshStudentsGridViewButton.UseVisualStyleBackColor = true;
            RefreshStudentsGridViewButton.Click += RefreshStudentsGridViewButton_Click_1;
            // 
            // ClearStudentBoxesButton
            // 
            ClearStudentBoxesButton.Location = new Point(188, 944);
            ClearStudentBoxesButton.Name = "ClearStudentBoxesButton";
            ClearStudentBoxesButton.Size = new Size(150, 46);
            ClearStudentBoxesButton.TabIndex = 23;
            ClearStudentBoxesButton.Text = "CLEAR";
            ClearStudentBoxesButton.UseVisualStyleBackColor = true;
            ClearStudentBoxesButton.Click += ClearStudentBoxesButton_Click;
            // 
            // SortFirstNameStudentButton
            // 
            SortFirstNameStudentButton.Location = new Point(509, 944);
            SortFirstNameStudentButton.Name = "SortFirstNameStudentButton";
            SortFirstNameStudentButton.Size = new Size(150, 114);
            SortFirstNameStudentButton.TabIndex = 22;
            SortFirstNameStudentButton.Text = "SORT FIRST NAME";
            SortFirstNameStudentButton.UseVisualStyleBackColor = true;
            SortFirstNameStudentButton.Click += SortFirstNameStudentButton_Click;
            // 
            // FilterStudentButton
            // 
            FilterStudentButton.Location = new Point(509, 892);
            FilterStudentButton.Name = "FilterStudentButton";
            FilterStudentButton.Size = new Size(150, 46);
            FilterStudentButton.TabIndex = 21;
            FilterStudentButton.Text = "FILTER";
            FilterStudentButton.UseVisualStyleBackColor = true;
            FilterStudentButton.Click += FilterStudentButton_Click;
            // 
            // UpdateStudentButton
            // 
            UpdateStudentButton.Location = new Point(188, 892);
            UpdateStudentButton.Name = "UpdateStudentButton";
            UpdateStudentButton.Size = new Size(150, 46);
            UpdateStudentButton.TabIndex = 20;
            UpdateStudentButton.Text = "UPDATE";
            UpdateStudentButton.UseVisualStyleBackColor = true;
            UpdateStudentButton.Click += UpdateStudentButton_Click;
            // 
            // DeleteStudentButton
            // 
            DeleteStudentButton.Location = new Point(32, 944);
            DeleteStudentButton.Name = "DeleteStudentButton";
            DeleteStudentButton.Size = new Size(150, 46);
            DeleteStudentButton.TabIndex = 19;
            DeleteStudentButton.Text = "DELETE";
            DeleteStudentButton.UseVisualStyleBackColor = true;
            DeleteStudentButton.Click += DeleteStudentButton_Click;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(32, 892);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(150, 46);
            AddStudentButton.TabIndex = 18;
            AddStudentButton.Text = "ADD";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 774);
            label10.Name = "label10";
            label10.Size = new Size(154, 32);
            label10.TabIndex = 17;
            label10.Text = "Departament";
            // 
            // StudentDepartamentBox
            // 
            StudentDepartamentBox.Location = new Point(32, 819);
            StudentDepartamentBox.Name = "StudentDepartamentBox";
            StudentDepartamentBox.Size = new Size(627, 39);
            StudentDepartamentBox.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 658);
            label9.Name = "label9";
            label9.Size = new Size(56, 32);
            label9.TabIndex = 15;
            label9.Text = "Age";
            // 
            // StudentAgeBox
            // 
            StudentAgeBox.Location = new Point(32, 703);
            StudentAgeBox.Name = "StudentAgeBox";
            StudentAgeBox.Size = new Size(627, 39);
            StudentAgeBox.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 549);
            label8.Name = "label8";
            label8.Size = new Size(192, 32);
            label8.TabIndex = 13;
            label8.Text = "Matricol number";
            // 
            // StudentMatricolNumberBox
            // 
            StudentMatricolNumberBox.Location = new Point(32, 594);
            StudentMatricolNumberBox.Name = "StudentMatricolNumberBox";
            StudentMatricolNumberBox.Size = new Size(627, 39);
            StudentMatricolNumberBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 434);
            label7.Name = "label7";
            label7.Size = new Size(51, 32);
            label7.TabIndex = 11;
            label7.Text = "Sex";
            // 
            // StudentSexBox
            // 
            StudentSexBox.Location = new Point(32, 479);
            StudentSexBox.Name = "StudentSexBox";
            StudentSexBox.Size = new Size(627, 39);
            StudentSexBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 327);
            label6.Name = "label6";
            label6.Size = new Size(60, 32);
            label6.TabIndex = 9;
            label6.Text = "CNP";
            // 
            // StudentCNPBox
            // 
            StudentCNPBox.Location = new Point(32, 372);
            StudentCNPBox.Name = "StudentCNPBox";
            StudentCNPBox.Size = new Size(627, 39);
            StudentCNPBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 216);
            label5.Name = "label5";
            label5.Size = new Size(122, 32);
            label5.TabIndex = 7;
            label5.Text = "Last name";
            // 
            // StudentLastNameBox
            // 
            StudentLastNameBox.Location = new Point(32, 261);
            StudentLastNameBox.Name = "StudentLastNameBox";
            StudentLastNameBox.Size = new Size(627, 39);
            StudentLastNameBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 114);
            label4.Name = "label4";
            label4.Size = new Size(125, 32);
            label4.TabIndex = 5;
            label4.Text = "First name";
            // 
            // StudentFirstNameBox
            // 
            StudentFirstNameBox.Location = new Point(32, 159);
            StudentFirstNameBox.Name = "StudentFirstNameBox";
            StudentFirstNameBox.Size = new Size(627, 39);
            StudentFirstNameBox.TabIndex = 4;
            // 
            // StudentsGridView
            // 
            StudentsGridView.BackgroundColor = SystemColors.Info;
            StudentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsGridView.Location = new Point(694, 116);
            StudentsGridView.Name = "StudentsGridView";
            StudentsGridView.RowHeadersWidth = 82;
            StudentsGridView.Size = new Size(1508, 885);
            StudentsGridView.TabIndex = 3;
            StudentsGridView.SelectionChanged += StudentsGridView_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 23);
            label3.Name = "label3";
            label3.Size = new Size(879, 50);
            label3.TabIndex = 2;
            label3.Text = "Manage Students data base and perform operations";
            // 
            // SortLastNameStudentButton
            // 
            SortLastNameStudentButton.Location = new Point(344, 944);
            SortLastNameStudentButton.Name = "SortLastNameStudentButton";
            SortLastNameStudentButton.Size = new Size(150, 114);
            SortLastNameStudentButton.TabIndex = 26;
            SortLastNameStudentButton.Text = "SORT LAST NAME";
            SortLastNameStudentButton.UseVisualStyleBackColor = true;
            SortLastNameStudentButton.Click += SortLastNameStudentButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2275, 1829);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            ConnectionPage.ResumeLayout(false);
            ConnectionPage.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentsDepartamentsChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ConnectionPage;
        private TabPage tabPage2;
        private TextBox ProfessorFirstNameBox;
        private Label label1;
        private Label titleConnectionPage;
        private Label label2;
        private TextBox ProfessorLastNameBox;
        private Button DeleteProfessorButton;
        private Button AddProfessorButton;
        private Button ConnectProfessorButton;
        private DataGridView StudentsGridView;
        private Label label3;
        private Label label8;
        private TextBox StudentMatricolNumberBox;
        private Label label7;
        private TextBox StudentSexBox;
        private Label label6;
        private TextBox StudentCNPBox;
        private Label label5;
        private TextBox StudentLastNameBox;
        private Label label4;
        private TextBox StudentFirstNameBox;
        private Button UpdateStudentButton;
        private Button DeleteStudentButton;
        private Button AddStudentButton;
        private Label label10;
        private TextBox StudentDepartamentBox;
        private Label label9;
        private TextBox StudentAgeBox;
        private Button SortFirstNameStudentButton;
        private Button FilterStudentButton;
        private Button ClearProfessorBoxesButton;
        private Button ClearStudentBoxesButton;
        private Button RefreshStudentsGridViewButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart StudentsDepartamentsChart;
        private Button SortLastNameStudentButton;
    }
}
