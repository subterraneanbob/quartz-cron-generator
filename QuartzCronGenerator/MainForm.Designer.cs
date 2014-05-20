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
            this.ExpressionPanel = new System.Windows.Forms.Panel();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.CronExpressionTextBox = new System.Windows.Forms.TextBox();
            this.WeeksPage = new System.Windows.Forms.TabPage();
            this.MondayCheckBox = new System.Windows.Forms.CheckBox();
            this.TuesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.MinutesComboBox3 = new System.Windows.Forms.ComboBox();
            this.HoursComboBox3 = new System.Windows.Forms.ComboBox();
            this.StartTimeLabel2 = new System.Windows.Forms.Label();
            this.WednesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.ThursdayCheckBox = new System.Windows.Forms.CheckBox();
            this.FridayCheckBox = new System.Windows.Forms.CheckBox();
            this.SaturdayCheckBox = new System.Windows.Forms.CheckBox();
            this.SundayCheckBox = new System.Windows.Forms.CheckBox();
            this.MainPanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.InputTabControl.SuspendLayout();
            this.MinutesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUpDown)).BeginInit();
            this.HoursPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursUpDown)).BeginInit();
            this.DaysPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaysUpDown)).BeginInit();
            this.ExpressionPanel.SuspendLayout();
            this.WeeksPage.SuspendLayout();
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
            this.ExpressionPanel.ResumeLayout(false);
            this.ExpressionPanel.PerformLayout();
            this.WeeksPage.ResumeLayout(false);
            this.WeeksPage.PerformLayout();
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
    }
}

