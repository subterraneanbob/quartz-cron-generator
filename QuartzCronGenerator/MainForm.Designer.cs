namespace QuartzCronGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.InputTabControl = new System.Windows.Forms.TabControl();
            this.MinutesPage = new System.Windows.Forms.TabPage();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.MinutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.EveryLabel1 = new System.Windows.Forms.Label();
            this.HoursPage = new System.Windows.Forms.TabPage();
            this.MinutesComboBox1 = new System.Windows.Forms.ComboBox();
            this.HoursComboBox1 = new System.Windows.Forms.ComboBox();
            this.AtTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.HourlyRadioButton = new System.Windows.Forms.RadioButton();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.HoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.DaysPage = new System.Windows.Forms.TabPage();
            this.MinutesComboBox2 = new System.Windows.Forms.ComboBox();
            this.HoursComboBox2 = new System.Windows.Forms.ComboBox();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EveryWeekDayRadioButton = new System.Windows.Forms.RadioButton();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.DaysUpDown = new System.Windows.Forms.NumericUpDown();
            this.DailyRadioButton = new System.Windows.Forms.RadioButton();
            this.WeeksPage = new System.Windows.Forms.TabPage();
            this.SundayCheckBox = new System.Windows.Forms.CheckBox();
            this.SaturdayCheckBox = new System.Windows.Forms.CheckBox();
            this.FridayCheckBox = new System.Windows.Forms.CheckBox();
            this.ThursdayCheckBox = new System.Windows.Forms.CheckBox();
            this.WednesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.MinutesComboBox3 = new System.Windows.Forms.ComboBox();
            this.HoursComboBox3 = new System.Windows.Forms.ComboBox();
            this.StartTimeLabel2 = new System.Windows.Forms.Label();
            this.TuesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.MondayCheckBox = new System.Windows.Forms.CheckBox();
            this.MonthsPage = new System.Windows.Forms.TabPage();
            this.MonthUpDown = new System.Windows.Forms.NumericUpDown();
            this.MonthUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.DayUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinutesComboBox4 = new System.Windows.Forms.ComboBox();
            this.HoursComboBox4 = new System.Windows.Forms.ComboBox();
            this.StartTimeLabel3 = new System.Windows.Forms.Label();
            this.MonthLabel2 = new System.Windows.Forms.Label();
            this.OfEveryLabel2 = new System.Windows.Forms.Label();
            this.DayOfWeekComboBox = new System.Windows.Forms.ComboBox();
            this.SeqNumberComboBox = new System.Windows.Forms.ComboBox();
            this.TheRadioButton = new System.Windows.Forms.RadioButton();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.OfEveryLabel = new System.Windows.Forms.Label();
            this.DayRadioButton = new System.Windows.Forms.RadioButton();
            this.YearsPage = new System.Windows.Forms.TabPage();
            this.MinutesComboBox5 = new System.Windows.Forms.ComboBox();
            this.HoursComboBox5 = new System.Windows.Forms.ComboBox();
            this.StartTimeLabel4 = new System.Windows.Forms.Label();
            this.MonthComboBox2 = new System.Windows.Forms.ComboBox();
            this.OfLabel = new System.Windows.Forms.Label();
            this.DayOfWeekComboBox2 = new System.Windows.Forms.ComboBox();
            this.SeqNumberComboBox2 = new System.Windows.Forms.ComboBox();
            this.TheRadioButton2 = new System.Windows.Forms.RadioButton();
            this.DayOfMonthUpDown = new System.Windows.Forms.NumericUpDown();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.EveryRadioButton = new System.Windows.Forms.RadioButton();
            this.ExpressionPanel = new System.Windows.Forms.Panel();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.CronExpressionTextBox = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.InputTabControl.SuspendLayout();
            this.MinutesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUpDown)).BeginInit();
            this.HoursPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursUpDown)).BeginInit();
            this.DaysPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaysUpDown)).BeginInit();
            this.WeeksPage.SuspendLayout();
            this.MonthsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayUpDown)).BeginInit();
            this.YearsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayOfMonthUpDown)).BeginInit();
            this.ExpressionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.InputPanel);
            this.MainPanel.Controls.Add(this.ExpressionPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(408, 335);
            this.MainPanel.TabIndex = 0;
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.InputTabControl);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPanel.Location = new System.Drawing.Point(0, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(408, 211);
            this.InputPanel.TabIndex = 5;
            // 
            // InputTabControl
            // 
            this.InputTabControl.Controls.Add(this.MinutesPage);
            this.InputTabControl.Controls.Add(this.HoursPage);
            this.InputTabControl.Controls.Add(this.DaysPage);
            this.InputTabControl.Controls.Add(this.WeeksPage);
            this.InputTabControl.Controls.Add(this.MonthsPage);
            this.InputTabControl.Controls.Add(this.YearsPage);
            this.InputTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputTabControl.Location = new System.Drawing.Point(0, 0);
            this.InputTabControl.Name = "InputTabControl";
            this.InputTabControl.SelectedIndex = 0;
            this.InputTabControl.Size = new System.Drawing.Size(408, 211);
            this.InputTabControl.TabIndex = 6;
            // 
            // MinutesPage
            // 
            this.MinutesPage.Controls.Add(this.MinutesLabel);
            this.MinutesPage.Controls.Add(this.MinutesUpDown);
            this.MinutesPage.Controls.Add(this.EveryLabel1);
            this.MinutesPage.Location = new System.Drawing.Point(4, 22);
            this.MinutesPage.Name = "MinutesPage";
            this.MinutesPage.Padding = new System.Windows.Forms.Padding(3);
            this.MinutesPage.Size = new System.Drawing.Size(400, 185);
            this.MinutesPage.TabIndex = 0;
            this.MinutesPage.Text = "Minutes";
            this.MinutesPage.UseVisualStyleBackColor = true;
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(110, 23);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(43, 13);
            this.MinutesLabel.TabIndex = 2;
            this.MinutesLabel.Text = "minutes";
            // 
            // MinutesUpDown
            // 
            this.MinutesUpDown.Location = new System.Drawing.Point(57, 21);
            this.MinutesUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.MinutesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinutesUpDown.Name = "MinutesUpDown";
            this.MinutesUpDown.Size = new System.Drawing.Size(47, 20);
            this.MinutesUpDown.TabIndex = 1;
            this.MinutesUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EveryLabel1
            // 
            this.EveryLabel1.AutoSize = true;
            this.EveryLabel1.Location = new System.Drawing.Point(17, 23);
            this.EveryLabel1.Name = "EveryLabel1";
            this.EveryLabel1.Size = new System.Drawing.Size(34, 13);
            this.EveryLabel1.TabIndex = 0;
            this.EveryLabel1.Text = "Every";
            // 
            // HoursPage
            // 
            this.HoursPage.Controls.Add(this.MinutesComboBox1);
            this.HoursPage.Controls.Add(this.HoursComboBox1);
            this.HoursPage.Controls.Add(this.AtTimeRadioButton);
            this.HoursPage.Controls.Add(this.HourlyRadioButton);
            this.HoursPage.Controls.Add(this.HoursLabel);
            this.HoursPage.Controls.Add(this.HoursUpDown);
            this.HoursPage.Location = new System.Drawing.Point(4, 22);
            this.HoursPage.Name = "HoursPage";
            this.HoursPage.Padding = new System.Windows.Forms.Padding(3);
            this.HoursPage.Size = new System.Drawing.Size(400, 185);
            this.HoursPage.TabIndex = 1;
            this.HoursPage.Text = "Hourly";
            this.HoursPage.UseVisualStyleBackColor = true;
            // 
            // MinutesComboBox1
            // 
            this.MinutesComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinutesComboBox1.FormattingEnabled = true;
            this.MinutesComboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.MinutesComboBox1.Location = new System.Drawing.Point(119, 47);
            this.MinutesComboBox1.Name = "MinutesComboBox1";
            this.MinutesComboBox1.Size = new System.Drawing.Size(47, 21);
            this.MinutesComboBox1.TabIndex = 6;
            this.MinutesComboBox1.Enter += new System.EventHandler(this.MinutesComboBox1_Enter);
            // 
            // HoursComboBox1
            // 
            this.HoursComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoursComboBox1.FormattingEnabled = true;
            this.HoursComboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.HoursComboBox1.Location = new System.Drawing.Point(66, 47);
            this.HoursComboBox1.Name = "HoursComboBox1";
            this.HoursComboBox1.Size = new System.Drawing.Size(47, 21);
            this.HoursComboBox1.TabIndex = 5;
            this.HoursComboBox1.Enter += new System.EventHandler(this.HoursComboBox1_Enter);
            // 
            // AtTimeRadioButton
            // 
            this.AtTimeRadioButton.AutoSize = true;
            this.AtTimeRadioButton.Location = new System.Drawing.Point(8, 48);
            this.AtTimeRadioButton.Name = "AtTimeRadioButton";
            this.AtTimeRadioButton.Size = new System.Drawing.Size(35, 17);
            this.AtTimeRadioButton.TabIndex = 4;
            this.AtTimeRadioButton.Text = "At";
            this.AtTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // HourlyRadioButton
            // 
            this.HourlyRadioButton.AutoSize = true;
            this.HourlyRadioButton.Checked = true;
            this.HourlyRadioButton.Location = new System.Drawing.Point(8, 21);
            this.HourlyRadioButton.Name = "HourlyRadioButton";
            this.HourlyRadioButton.Size = new System.Drawing.Size(52, 17);
            this.HourlyRadioButton.TabIndex = 3;
            this.HourlyRadioButton.TabStop = true;
            this.HourlyRadioButton.Text = "Every";
            this.HourlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(119, 23);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(33, 13);
            this.HoursLabel.TabIndex = 2;
            this.HoursLabel.Text = "hours";
            // 
            // HoursUpDown
            // 
            this.HoursUpDown.Location = new System.Drawing.Point(66, 21);
            this.HoursUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.HoursUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HoursUpDown.Name = "HoursUpDown";
            this.HoursUpDown.Size = new System.Drawing.Size(47, 20);
            this.HoursUpDown.TabIndex = 1;
            this.HoursUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HoursUpDown.Enter += new System.EventHandler(this.HoursUpDown_Enter);
            // 
            // DaysPage
            // 
            this.DaysPage.Controls.Add(this.MinutesComboBox2);
            this.DaysPage.Controls.Add(this.HoursComboBox2);
            this.DaysPage.Controls.Add(this.StartTimeLabel);
            this.DaysPage.Controls.Add(this.EveryWeekDayRadioButton);
            this.DaysPage.Controls.Add(this.DaysLabel);
            this.DaysPage.Controls.Add(this.DaysUpDown);
            this.DaysPage.Controls.Add(this.DailyRadioButton);
            this.DaysPage.Location = new System.Drawing.Point(4, 22);
            this.DaysPage.Name = "DaysPage";
            this.DaysPage.Padding = new System.Windows.Forms.Padding(3);
            this.DaysPage.Size = new System.Drawing.Size(400, 185);
            this.DaysPage.TabIndex = 2;
            this.DaysPage.Text = "Daily";
            this.DaysPage.UseVisualStyleBackColor = true;
            // 
            // MinutesComboBox2
            // 
            this.MinutesComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinutesComboBox2.FormattingEnabled = true;
            this.MinutesComboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.MinutesComboBox2.Location = new System.Drawing.Point(119, 79);
            this.MinutesComboBox2.Name = "MinutesComboBox2";
            this.MinutesComboBox2.Size = new System.Drawing.Size(47, 21);
            this.MinutesComboBox2.TabIndex = 10;
            // 
            // HoursComboBox2
            // 
            this.HoursComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoursComboBox2.FormattingEnabled = true;
            this.HoursComboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.HoursComboBox2.Location = new System.Drawing.Point(66, 79);
            this.HoursComboBox2.Name = "HoursComboBox2";
            this.HoursComboBox2.Size = new System.Drawing.Size(47, 21);
            this.HoursComboBox2.TabIndex = 9;
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(9, 82);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(51, 13);
            this.StartTimeLabel.TabIndex = 8;
            this.StartTimeLabel.Text = "Start time";
            // 
            // EveryWeekDayRadioButton
            // 
            this.EveryWeekDayRadioButton.AutoSize = true;
            this.EveryWeekDayRadioButton.Location = new System.Drawing.Point(8, 53);
            this.EveryWeekDayRadioButton.Name = "EveryWeekDayRadioButton";
            this.EveryWeekDayRadioButton.Size = new System.Drawing.Size(101, 17);
            this.EveryWeekDayRadioButton.TabIndex = 7;
            this.EveryWeekDayRadioButton.Text = "Every week day";
            this.EveryWeekDayRadioButton.UseVisualStyleBackColor = true;
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Location = new System.Drawing.Point(119, 23);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(29, 13);
            this.DaysLabel.TabIndex = 6;
            this.DaysLabel.Text = "days";
            // 
            // DaysUpDown
            // 
            this.DaysUpDown.Location = new System.Drawing.Point(66, 21);
            this.DaysUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.DaysUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DaysUpDown.Name = "DaysUpDown";
            this.DaysUpDown.Size = new System.Drawing.Size(47, 20);
            this.DaysUpDown.TabIndex = 5;
            this.DaysUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DaysUpDown.Enter += new System.EventHandler(this.DaysUpDown_Enter);
            // 
            // DailyRadioButton
            // 
            this.DailyRadioButton.AutoSize = true;
            this.DailyRadioButton.Checked = true;
            this.DailyRadioButton.Location = new System.Drawing.Point(8, 21);
            this.DailyRadioButton.Name = "DailyRadioButton";
            this.DailyRadioButton.Size = new System.Drawing.Size(52, 17);
            this.DailyRadioButton.TabIndex = 4;
            this.DailyRadioButton.TabStop = true;
            this.DailyRadioButton.Text = "Every";
            this.DailyRadioButton.UseVisualStyleBackColor = true;
            // 
            // WeeksPage
            // 
            this.WeeksPage.Controls.Add(this.SundayCheckBox);
            this.WeeksPage.Controls.Add(this.SaturdayCheckBox);
            this.WeeksPage.Controls.Add(this.FridayCheckBox);
            this.WeeksPage.Controls.Add(this.ThursdayCheckBox);
            this.WeeksPage.Controls.Add(this.WednesdayCheckBox);
            this.WeeksPage.Controls.Add(this.MinutesComboBox3);
            this.WeeksPage.Controls.Add(this.HoursComboBox3);
            this.WeeksPage.Controls.Add(this.StartTimeLabel2);
            this.WeeksPage.Controls.Add(this.TuesdayCheckBox);
            this.WeeksPage.Controls.Add(this.MondayCheckBox);
            this.WeeksPage.Location = new System.Drawing.Point(4, 22);
            this.WeeksPage.Name = "WeeksPage";
            this.WeeksPage.Padding = new System.Windows.Forms.Padding(3);
            this.WeeksPage.Size = new System.Drawing.Size(400, 185);
            this.WeeksPage.TabIndex = 3;
            this.WeeksPage.Text = "Weekly";
            this.WeeksPage.UseVisualStyleBackColor = true;
            // 
            // SundayCheckBox
            // 
            this.SundayCheckBox.AutoSize = true;
            this.SundayCheckBox.Location = new System.Drawing.Point(163, 41);
            this.SundayCheckBox.Name = "SundayCheckBox";
            this.SundayCheckBox.Size = new System.Drawing.Size(62, 17);
            this.SundayCheckBox.TabIndex = 18;
            this.SundayCheckBox.Text = "Sunday";
            this.SundayCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaturdayCheckBox
            // 
            this.SaturdayCheckBox.AutoSize = true;
            this.SaturdayCheckBox.Location = new System.Drawing.Point(90, 41);
            this.SaturdayCheckBox.Name = "SaturdayCheckBox";
            this.SaturdayCheckBox.Size = new System.Drawing.Size(68, 17);
            this.SaturdayCheckBox.TabIndex = 17;
            this.SaturdayCheckBox.Text = "Saturday";
            this.SaturdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // FridayCheckBox
            // 
            this.FridayCheckBox.AutoSize = true;
            this.FridayCheckBox.Location = new System.Drawing.Point(20, 41);
            this.FridayCheckBox.Name = "FridayCheckBox";
            this.FridayCheckBox.Size = new System.Drawing.Size(54, 17);
            this.FridayCheckBox.TabIndex = 16;
            this.FridayCheckBox.Text = "Friday";
            this.FridayCheckBox.UseVisualStyleBackColor = true;
            // 
            // ThursdayCheckBox
            // 
            this.ThursdayCheckBox.AutoSize = true;
            this.ThursdayCheckBox.Location = new System.Drawing.Point(252, 18);
            this.ThursdayCheckBox.Name = "ThursdayCheckBox";
            this.ThursdayCheckBox.Size = new System.Drawing.Size(70, 17);
            this.ThursdayCheckBox.TabIndex = 15;
            this.ThursdayCheckBox.Text = "Thursday";
            this.ThursdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // WednesdayCheckBox
            // 
            this.WednesdayCheckBox.AutoSize = true;
            this.WednesdayCheckBox.Location = new System.Drawing.Point(163, 18);
            this.WednesdayCheckBox.Name = "WednesdayCheckBox";
            this.WednesdayCheckBox.Size = new System.Drawing.Size(83, 17);
            this.WednesdayCheckBox.TabIndex = 14;
            this.WednesdayCheckBox.Text = "Wednesday";
            this.WednesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinutesComboBox3
            // 
            this.MinutesComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinutesComboBox3.FormattingEnabled = true;
            this.MinutesComboBox3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.MinutesComboBox3.Location = new System.Drawing.Point(127, 94);
            this.MinutesComboBox3.Name = "MinutesComboBox3";
            this.MinutesComboBox3.Size = new System.Drawing.Size(47, 21);
            this.MinutesComboBox3.TabIndex = 13;
            // 
            // HoursComboBox3
            // 
            this.HoursComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoursComboBox3.FormattingEnabled = true;
            this.HoursComboBox3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.HoursComboBox3.Location = new System.Drawing.Point(74, 94);
            this.HoursComboBox3.Name = "HoursComboBox3";
            this.HoursComboBox3.Size = new System.Drawing.Size(47, 21);
            this.HoursComboBox3.TabIndex = 12;
            // 
            // StartTimeLabel2
            // 
            this.StartTimeLabel2.AutoSize = true;
            this.StartTimeLabel2.Location = new System.Drawing.Point(17, 97);
            this.StartTimeLabel2.Name = "StartTimeLabel2";
            this.StartTimeLabel2.Size = new System.Drawing.Size(51, 13);
            this.StartTimeLabel2.TabIndex = 11;
            this.StartTimeLabel2.Text = "Start time";
            // 
            // TuesdayCheckBox
            // 
            this.TuesdayCheckBox.AutoSize = true;
            this.TuesdayCheckBox.Location = new System.Drawing.Point(90, 18);
            this.TuesdayCheckBox.Name = "TuesdayCheckBox";
            this.TuesdayCheckBox.Size = new System.Drawing.Size(67, 17);
            this.TuesdayCheckBox.TabIndex = 1;
            this.TuesdayCheckBox.Text = "Tuesday";
            this.TuesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // MondayCheckBox
            // 
            this.MondayCheckBox.AutoSize = true;
            this.MondayCheckBox.Location = new System.Drawing.Point(20, 18);
            this.MondayCheckBox.Name = "MondayCheckBox";
            this.MondayCheckBox.Size = new System.Drawing.Size(64, 17);
            this.MondayCheckBox.TabIndex = 0;
            this.MondayCheckBox.Text = "Monday";
            this.MondayCheckBox.UseVisualStyleBackColor = true;
            // 
            // MonthsPage
            // 
            this.MonthsPage.Controls.Add(this.MonthUpDown);
            this.MonthsPage.Controls.Add(this.MonthUpDown2);
            this.MonthsPage.Controls.Add(this.DayUpDown);
            this.MonthsPage.Controls.Add(this.MinutesComboBox4);
            this.MonthsPage.Controls.Add(this.HoursComboBox4);
            this.MonthsPage.Controls.Add(this.StartTimeLabel3);
            this.MonthsPage.Controls.Add(this.MonthLabel2);
            this.MonthsPage.Controls.Add(this.OfEveryLabel2);
            this.MonthsPage.Controls.Add(this.DayOfWeekComboBox);
            this.MonthsPage.Controls.Add(this.SeqNumberComboBox);
            this.MonthsPage.Controls.Add(this.TheRadioButton);
            this.MonthsPage.Controls.Add(this.MonthLabel);
            this.MonthsPage.Controls.Add(this.OfEveryLabel);
            this.MonthsPage.Controls.Add(this.DayRadioButton);
            this.MonthsPage.Location = new System.Drawing.Point(4, 22);
            this.MonthsPage.Name = "MonthsPage";
            this.MonthsPage.Padding = new System.Windows.Forms.Padding(3);
            this.MonthsPage.Size = new System.Drawing.Size(400, 185);
            this.MonthsPage.TabIndex = 4;
            this.MonthsPage.Text = "Montly";
            this.MonthsPage.UseVisualStyleBackColor = true;
            // 
            // MonthUpDown
            // 
            this.MonthUpDown.Location = new System.Drawing.Point(160, 16);
            this.MonthUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.MonthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MonthUpDown.Name = "MonthUpDown";
            this.MonthUpDown.Size = new System.Drawing.Size(39, 20);
            this.MonthUpDown.TabIndex = 18;
            this.MonthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MonthUpDown2
            // 
            this.MonthUpDown2.Location = new System.Drawing.Point(274, 49);
            this.MonthUpDown2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.MonthUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MonthUpDown2.Name = "MonthUpDown2";
            this.MonthUpDown2.Size = new System.Drawing.Size(39, 20);
            this.MonthUpDown2.TabIndex = 17;
            this.MonthUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DayUpDown
            // 
            this.DayUpDown.Location = new System.Drawing.Point(62, 16);
            this.DayUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.DayUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DayUpDown.Name = "DayUpDown";
            this.DayUpDown.Size = new System.Drawing.Size(39, 20);
            this.DayUpDown.TabIndex = 16;
            this.DayUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinutesComboBox4
            // 
            this.MinutesComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinutesComboBox4.FormattingEnabled = true;
            this.MinutesComboBox4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.MinutesComboBox4.Location = new System.Drawing.Point(123, 86);
            this.MinutesComboBox4.Name = "MinutesComboBox4";
            this.MinutesComboBox4.Size = new System.Drawing.Size(47, 21);
            this.MinutesComboBox4.TabIndex = 15;
            // 
            // HoursComboBox4
            // 
            this.HoursComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoursComboBox4.FormattingEnabled = true;
            this.HoursComboBox4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.HoursComboBox4.Location = new System.Drawing.Point(70, 86);
            this.HoursComboBox4.Name = "HoursComboBox4";
            this.HoursComboBox4.Size = new System.Drawing.Size(47, 21);
            this.HoursComboBox4.TabIndex = 14;
            // 
            // StartTimeLabel3
            // 
            this.StartTimeLabel3.AutoSize = true;
            this.StartTimeLabel3.Location = new System.Drawing.Point(13, 89);
            this.StartTimeLabel3.Name = "StartTimeLabel3";
            this.StartTimeLabel3.Size = new System.Drawing.Size(51, 13);
            this.StartTimeLabel3.TabIndex = 11;
            this.StartTimeLabel3.Text = "Start time";
            // 
            // MonthLabel2
            // 
            this.MonthLabel2.AutoSize = true;
            this.MonthLabel2.Location = new System.Drawing.Point(321, 52);
            this.MonthLabel2.Name = "MonthLabel2";
            this.MonthLabel2.Size = new System.Drawing.Size(47, 13);
            this.MonthLabel2.TabIndex = 10;
            this.MonthLabel2.Text = "month(s)";
            // 
            // OfEveryLabel2
            // 
            this.OfEveryLabel2.AutoSize = true;
            this.OfEveryLabel2.Location = new System.Drawing.Point(223, 53);
            this.OfEveryLabel2.Name = "OfEveryLabel2";
            this.OfEveryLabel2.Size = new System.Drawing.Size(45, 13);
            this.OfEveryLabel2.TabIndex = 8;
            this.OfEveryLabel2.Text = "of every";
            // 
            // DayOfWeekComboBox
            // 
            this.DayOfWeekComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayOfWeekComboBox.FormattingEnabled = true;
            this.DayOfWeekComboBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.DayOfWeekComboBox.Location = new System.Drawing.Point(145, 49);
            this.DayOfWeekComboBox.Name = "DayOfWeekComboBox";
            this.DayOfWeekComboBox.Size = new System.Drawing.Size(72, 21);
            this.DayOfWeekComboBox.TabIndex = 7;
            // 
            // SeqNumberComboBox
            // 
            this.SeqNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeqNumberComboBox.FormattingEnabled = true;
            this.SeqNumberComboBox.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth"});
            this.SeqNumberComboBox.Location = new System.Drawing.Point(66, 49);
            this.SeqNumberComboBox.Name = "SeqNumberComboBox";
            this.SeqNumberComboBox.Size = new System.Drawing.Size(73, 21);
            this.SeqNumberComboBox.TabIndex = 6;
            // 
            // TheRadioButton
            // 
            this.TheRadioButton.AutoSize = true;
            this.TheRadioButton.Location = new System.Drawing.Point(12, 51);
            this.TheRadioButton.Name = "TheRadioButton";
            this.TheRadioButton.Size = new System.Drawing.Size(44, 17);
            this.TheRadioButton.TabIndex = 5;
            this.TheRadioButton.Text = "The";
            this.TheRadioButton.UseVisualStyleBackColor = true;
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(205, 19);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(47, 13);
            this.MonthLabel.TabIndex = 4;
            this.MonthLabel.Text = "month(s)";
            // 
            // OfEveryLabel
            // 
            this.OfEveryLabel.AutoSize = true;
            this.OfEveryLabel.Location = new System.Drawing.Point(109, 18);
            this.OfEveryLabel.Name = "OfEveryLabel";
            this.OfEveryLabel.Size = new System.Drawing.Size(45, 13);
            this.OfEveryLabel.TabIndex = 2;
            this.OfEveryLabel.Text = "of every";
            // 
            // DayRadioButton
            // 
            this.DayRadioButton.AutoSize = true;
            this.DayRadioButton.Checked = true;
            this.DayRadioButton.Location = new System.Drawing.Point(12, 17);
            this.DayRadioButton.Name = "DayRadioButton";
            this.DayRadioButton.Size = new System.Drawing.Size(44, 17);
            this.DayRadioButton.TabIndex = 0;
            this.DayRadioButton.TabStop = true;
            this.DayRadioButton.Text = "Day";
            this.DayRadioButton.UseVisualStyleBackColor = true;
            // 
            // YearsPage
            // 
            this.YearsPage.Controls.Add(this.MinutesComboBox5);
            this.YearsPage.Controls.Add(this.HoursComboBox5);
            this.YearsPage.Controls.Add(this.StartTimeLabel4);
            this.YearsPage.Controls.Add(this.MonthComboBox2);
            this.YearsPage.Controls.Add(this.OfLabel);
            this.YearsPage.Controls.Add(this.DayOfWeekComboBox2);
            this.YearsPage.Controls.Add(this.SeqNumberComboBox2);
            this.YearsPage.Controls.Add(this.TheRadioButton2);
            this.YearsPage.Controls.Add(this.DayOfMonthUpDown);
            this.YearsPage.Controls.Add(this.MonthComboBox);
            this.YearsPage.Controls.Add(this.EveryRadioButton);
            this.YearsPage.Location = new System.Drawing.Point(4, 22);
            this.YearsPage.Name = "YearsPage";
            this.YearsPage.Padding = new System.Windows.Forms.Padding(3);
            this.YearsPage.Size = new System.Drawing.Size(400, 185);
            this.YearsPage.TabIndex = 5;
            this.YearsPage.Text = "Yearly";
            this.YearsPage.UseVisualStyleBackColor = true;
            // 
            // MinutesComboBox5
            // 
            this.MinutesComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinutesComboBox5.FormattingEnabled = true;
            this.MinutesComboBox5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.MinutesComboBox5.Location = new System.Drawing.Point(119, 86);
            this.MinutesComboBox5.Name = "MinutesComboBox5";
            this.MinutesComboBox5.Size = new System.Drawing.Size(47, 21);
            this.MinutesComboBox5.TabIndex = 27;
            // 
            // HoursComboBox5
            // 
            this.HoursComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoursComboBox5.FormattingEnabled = true;
            this.HoursComboBox5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.HoursComboBox5.Location = new System.Drawing.Point(66, 86);
            this.HoursComboBox5.Name = "HoursComboBox5";
            this.HoursComboBox5.Size = new System.Drawing.Size(47, 21);
            this.HoursComboBox5.TabIndex = 26;
            // 
            // StartTimeLabel4
            // 
            this.StartTimeLabel4.AutoSize = true;
            this.StartTimeLabel4.Location = new System.Drawing.Point(9, 89);
            this.StartTimeLabel4.Name = "StartTimeLabel4";
            this.StartTimeLabel4.Size = new System.Drawing.Size(51, 13);
            this.StartTimeLabel4.TabIndex = 25;
            this.StartTimeLabel4.Text = "Start time";
            // 
            // MonthComboBox2
            // 
            this.MonthComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox2.FormattingEnabled = true;
            this.MonthComboBox2.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthComboBox2.Location = new System.Drawing.Point(245, 47);
            this.MonthComboBox2.Name = "MonthComboBox2";
            this.MonthComboBox2.Size = new System.Drawing.Size(121, 21);
            this.MonthComboBox2.TabIndex = 24;
            // 
            // OfLabel
            // 
            this.OfLabel.AutoSize = true;
            this.OfLabel.Location = new System.Drawing.Point(223, 51);
            this.OfLabel.Name = "OfLabel";
            this.OfLabel.Size = new System.Drawing.Size(16, 13);
            this.OfLabel.TabIndex = 23;
            this.OfLabel.Text = "of";
            // 
            // DayOfWeekComboBox2
            // 
            this.DayOfWeekComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayOfWeekComboBox2.FormattingEnabled = true;
            this.DayOfWeekComboBox2.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.DayOfWeekComboBox2.Location = new System.Drawing.Point(145, 47);
            this.DayOfWeekComboBox2.Name = "DayOfWeekComboBox2";
            this.DayOfWeekComboBox2.Size = new System.Drawing.Size(72, 21);
            this.DayOfWeekComboBox2.TabIndex = 22;
            // 
            // SeqNumberComboBox2
            // 
            this.SeqNumberComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeqNumberComboBox2.FormattingEnabled = true;
            this.SeqNumberComboBox2.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth"});
            this.SeqNumberComboBox2.Location = new System.Drawing.Point(66, 47);
            this.SeqNumberComboBox2.Name = "SeqNumberComboBox2";
            this.SeqNumberComboBox2.Size = new System.Drawing.Size(73, 21);
            this.SeqNumberComboBox2.TabIndex = 21;
            // 
            // TheRadioButton2
            // 
            this.TheRadioButton2.AutoSize = true;
            this.TheRadioButton2.Location = new System.Drawing.Point(8, 49);
            this.TheRadioButton2.Name = "TheRadioButton2";
            this.TheRadioButton2.Size = new System.Drawing.Size(44, 17);
            this.TheRadioButton2.TabIndex = 20;
            this.TheRadioButton2.Text = "The";
            this.TheRadioButton2.UseVisualStyleBackColor = true;
            // 
            // DayOfMonthUpDown
            // 
            this.DayOfMonthUpDown.Location = new System.Drawing.Point(193, 15);
            this.DayOfMonthUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.DayOfMonthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DayOfMonthUpDown.Name = "DayOfMonthUpDown";
            this.DayOfMonthUpDown.Size = new System.Drawing.Size(47, 20);
            this.DayOfMonthUpDown.TabIndex = 19;
            this.DayOfMonthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthComboBox.Location = new System.Drawing.Point(66, 14);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.MonthComboBox.TabIndex = 1;
            // 
            // EveryRadioButton
            // 
            this.EveryRadioButton.AutoSize = true;
            this.EveryRadioButton.Checked = true;
            this.EveryRadioButton.Location = new System.Drawing.Point(8, 15);
            this.EveryRadioButton.Name = "EveryRadioButton";
            this.EveryRadioButton.Size = new System.Drawing.Size(52, 17);
            this.EveryRadioButton.TabIndex = 0;
            this.EveryRadioButton.TabStop = true;
            this.EveryRadioButton.Text = "Every";
            this.EveryRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExpressionPanel
            // 
            this.ExpressionPanel.Controls.Add(this.CopyButton);
            this.ExpressionPanel.Controls.Add(this.ButtonGenerate);
            this.ExpressionPanel.Controls.Add(this.CronExpressionTextBox);
            this.ExpressionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExpressionPanel.Location = new System.Drawing.Point(0, 211);
            this.ExpressionPanel.Name = "ExpressionPanel";
            this.ExpressionPanel.Size = new System.Drawing.Size(408, 124);
            this.ExpressionPanel.TabIndex = 3;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(12, 73);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(101, 21);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.Text = "Copy to clipboard";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGenerate.Location = new System.Drawing.Point(4, 6);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(400, 34);
            this.ButtonGenerate.TabIndex = 0;
            this.ButtonGenerate.Text = "Generate Cron Expression";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // CronExpressionTextBox
            // 
            this.CronExpressionTextBox.Location = new System.Drawing.Point(119, 74);
            this.CronExpressionTextBox.Name = "CronExpressionTextBox";
            this.CronExpressionTextBox.ReadOnly = true;
            this.CronExpressionTextBox.Size = new System.Drawing.Size(277, 20);
            this.CronExpressionTextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 335);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Quartz Cron Expression Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.InputPanel.ResumeLayout(false);
            this.InputTabControl.ResumeLayout(false);
            this.MinutesPage.ResumeLayout(false);
            this.MinutesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUpDown)).EndInit();
            this.HoursPage.ResumeLayout(false);
            this.HoursPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursUpDown)).EndInit();
            this.DaysPage.ResumeLayout(false);
            this.DaysPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaysUpDown)).EndInit();
            this.WeeksPage.ResumeLayout(false);
            this.WeeksPage.PerformLayout();
            this.MonthsPage.ResumeLayout(false);
            this.MonthsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayUpDown)).EndInit();
            this.YearsPage.ResumeLayout(false);
            this.YearsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayOfMonthUpDown)).EndInit();
            this.ExpressionPanel.ResumeLayout(false);
            this.ExpressionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Panel ExpressionPanel;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.TextBox CronExpressionTextBox;
        private System.Windows.Forms.TabControl InputTabControl;
        private System.Windows.Forms.TabPage MinutesPage;
        private System.Windows.Forms.TabPage HoursPage;
        private System.Windows.Forms.Label EveryLabel1;
        private System.Windows.Forms.NumericUpDown MinutesUpDown;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.NumericUpDown HoursUpDown;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.RadioButton HourlyRadioButton;
        private System.Windows.Forms.RadioButton AtTimeRadioButton;
        private System.Windows.Forms.ComboBox MinutesComboBox1;
        private System.Windows.Forms.ComboBox HoursComboBox1;
        private System.Windows.Forms.TabPage DaysPage;
        private System.Windows.Forms.RadioButton DailyRadioButton;
        private System.Windows.Forms.NumericUpDown DaysUpDown;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.RadioButton EveryWeekDayRadioButton;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.ComboBox MinutesComboBox2;
        private System.Windows.Forms.ComboBox HoursComboBox2;
        private System.Windows.Forms.TabPage WeeksPage;
        private System.Windows.Forms.CheckBox MondayCheckBox;
        private System.Windows.Forms.CheckBox TuesdayCheckBox;
        private System.Windows.Forms.ComboBox MinutesComboBox3;
        private System.Windows.Forms.ComboBox HoursComboBox3;
        private System.Windows.Forms.Label StartTimeLabel2;
        private System.Windows.Forms.CheckBox SundayCheckBox;
        private System.Windows.Forms.CheckBox SaturdayCheckBox;
        private System.Windows.Forms.CheckBox FridayCheckBox;
        private System.Windows.Forms.CheckBox ThursdayCheckBox;
        private System.Windows.Forms.CheckBox WednesdayCheckBox;
        private System.Windows.Forms.TabPage MonthsPage;
        private System.Windows.Forms.RadioButton DayRadioButton;
        private System.Windows.Forms.Label OfEveryLabel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.RadioButton TheRadioButton;
        private System.Windows.Forms.ComboBox DayOfWeekComboBox;
        private System.Windows.Forms.ComboBox SeqNumberComboBox;
        private System.Windows.Forms.Label OfEveryLabel2;
        private System.Windows.Forms.Label MonthLabel2;
        private System.Windows.Forms.Label StartTimeLabel3;
        private System.Windows.Forms.ComboBox MinutesComboBox4;
        private System.Windows.Forms.ComboBox HoursComboBox4;
        private System.Windows.Forms.NumericUpDown DayUpDown;
        private System.Windows.Forms.NumericUpDown MonthUpDown2;
        private System.Windows.Forms.NumericUpDown MonthUpDown;
        private System.Windows.Forms.TabPage YearsPage;
        private System.Windows.Forms.RadioButton EveryRadioButton;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.NumericUpDown DayOfMonthUpDown;
        private System.Windows.Forms.ComboBox MonthComboBox2;
        private System.Windows.Forms.Label OfLabel;
        private System.Windows.Forms.ComboBox DayOfWeekComboBox2;
        private System.Windows.Forms.ComboBox SeqNumberComboBox2;
        private System.Windows.Forms.RadioButton TheRadioButton2;
        private System.Windows.Forms.ComboBox MinutesComboBox5;
        private System.Windows.Forms.ComboBox HoursComboBox5;
        private System.Windows.Forms.Label StartTimeLabel4;
    }
}

