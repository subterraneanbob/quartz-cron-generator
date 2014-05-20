using System;
using System.Windows.Forms;

namespace QuartzCronGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            CronExpressionTextBox.Clear();

            if (InputTabControl.SelectedTab == InputTabControl.TabPages["MinutesPage"])
            {
                CronExpressionTextBox.Text = CronExpression.EveryNMinutes((int)MinutesUpDown.Value);
            }
            else if (InputTabControl.SelectedTab == InputTabControl.TabPages["HoursPage"])
            {
                if (HourlyRadioButton.Checked)
                {
                    CronExpressionTextBox.Text = CronExpression.EveryNHours((int)HoursUpDown.Value);
                }
                else if (AtTimeRadioButton.Checked)
                {
                    CronExpressionTextBox.Text = CronExpression.EveryDayAt(Convert.ToInt32(HoursComboBox1.SelectedItem),
                                                                           Convert.ToInt32(MinutesComboBox1.SelectedItem));
                }
            }
            else if (InputTabControl.SelectedTab == InputTabControl.TabPages["DaysPage"])
            {
                if (DailyRadioButton.Checked)
                {
                    CronExpressionTextBox.Text = CronExpression.EveryNDaysAt((int)DaysUpDown.Value,
                                                                             Convert.ToInt32(HoursComboBox2.SelectedItem),
                                                                             Convert.ToInt32(MinutesComboBox2.SelectedItem));
                }
                else if (EveryWeekDayRadioButton.Checked)
                {
                    CronExpressionTextBox.Text = CronExpression.EveryWeekDayAt(Convert.ToInt32(HoursComboBox2.SelectedItem),
                                                                               Convert.ToInt32(MinutesComboBox2.SelectedItem));
                }
            }
            else if (InputTabControl.SelectedTab == InputTabControl.TabPages["WeeksPage"])
            {
                int total = 0;
                if (MondayCheckBox.Checked) total += 1;
                if (TuesdayCheckBox.Checked) total += 2;
                if (WednesdayCheckBox.Checked) total += 4;
                if (ThursdayCheckBox.Checked) total += 8;
                if (FridayCheckBox.Checked) total += 16;
                if (SaturdayCheckBox.Checked) total += 32;
                if (SundayCheckBox.Checked) total += 64;

                if (total == 0)
                {
                    MessageBox.Show("At least one day of the week is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CronExpressionTextBox.Text = CronExpression.EverySpecificWeekDayAt(Convert.ToInt32(HoursComboBox3.SelectedItem),
                                                                                       Convert.ToInt32(MinutesComboBox3.SelectedItem), (DaysOfWeek)total);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HoursComboBox1.SelectedIndex = 12;
            MinutesComboBox1.SelectedIndex = 0;

            HoursComboBox2.SelectedIndex = 12;
            MinutesComboBox2.SelectedIndex = 0;

            HoursComboBox3.SelectedIndex = 12;
            MinutesComboBox3.SelectedIndex = 0;
        }

        private void HoursComboBox1_Enter(object sender, EventArgs e)
        {
            AtTimeRadioButton.Checked = true;
        }

        private void MinutesComboBox1_Enter(object sender, EventArgs e)
        {
            AtTimeRadioButton.Checked = true;
        }

        private void HoursUpDown_Enter(object sender, EventArgs e)
        {
            HourlyRadioButton.Checked = true;
        }

        private void DaysUpDown_Enter(object sender, EventArgs e)
        {
            DailyRadioButton.Checked = true;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CronExpressionTextBox.Text);
        }
    }
}
