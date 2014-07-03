using System;
using System.Windows.Forms;
using QuartzCronGenerator.Properties;

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
                    ShowError("At least one day of the week is required.");
                }
                else
                {
                    CronExpressionTextBox.Text = CronExpression.EverySpecificWeekDayAt(Convert.ToInt32(HoursComboBox3.SelectedItem),
                                                                                       Convert.ToInt32(MinutesComboBox3.SelectedItem), (DaysOfWeek)total);
                }
            }
            else if (InputTabControl.SelectedTab == InputTabControl.TabPages["MonthsPage"])
            {
                if (DayRadioButton.Checked)
                {
                    CronExpressionTextBox.Text =
                        CronExpression.EverySpecificDayEveryNMonthAt(Convert.ToInt32(DayUpDown.Value),
                                                                     Convert.ToInt32(MonthUpDown.Value),
                                                                     Convert.ToInt32(HoursComboBox4.SelectedItem),
                                                                     Convert.ToInt32(MinutesComboBox4.SelectedItem));
                }
                else if (TheRadioButton.Checked)
                {
                    // Convert combo box index to enum (0 -> 1, 1 -> 2, 2 -> 4, etc)
                    var days = (DaysOfWeek)(Math.Pow(2, DayOfWeekComboBox.SelectedIndex));

                    // Convert combo box (first, second, third, fourth) to enum
                    var seqNumber = (DaySeqNumber)(SeqNumberComboBox.SelectedIndex + 1);

                    CronExpressionTextBox.Text =
                        CronExpression.EverySpecificSeqWeekDayEveryNMonthAt(seqNumber,
                                                                            days,
                                                                            Convert.ToInt32(MonthUpDown2.Value),
                                                                            Convert.ToInt32(HoursComboBox4.SelectedItem),
                                                                            Convert.ToInt32(MinutesComboBox4.SelectedItem));
                }
            }
            else if (InputTabControl.SelectedTab == InputTabControl.TabPages["YearsPage"])
            {
                if (EveryRadioButton.Checked)
                {
                    var month = (Months)(MonthComboBox.SelectedIndex + 1);

                    CronExpressionTextBox.Text =
                        CronExpression.EverySpecificDayOfMonthAt(month,
                                                                 Convert.ToInt32(DayOfMonthUpDown.Value),
                                                                 Convert.ToInt32(HoursComboBox5.SelectedItem),
                                                                 Convert.ToInt32(MinutesComboBox5.SelectedItem));
                }
                else if (TheRadioButton2.Checked)
                {
                    // Convert combo box index to enum (0 -> 1, 1 -> 2, 2 -> 4, etc)
                    var days = (DaysOfWeek)(Math.Pow(2, DayOfWeekComboBox2.SelectedIndex));

                    // Convert combo box (first, second, third, fourth) to enum
                    var seqNumber = (DaySeqNumber)(SeqNumberComboBox2.SelectedIndex + 1);

                    var month = (Months)(MonthComboBox2.SelectedIndex + 1);

                    CronExpressionTextBox.Text =
                        CronExpression.EverySpecificSeqWeekDayOfMonthAt(seqNumber, 
                                                                        days, 
                                                                        month, 
                                                                        Convert.ToInt32(HoursComboBox5.SelectedItem),
                                                                        Convert.ToInt32(MinutesComboBox5.SelectedItem));
                }
            }
        }

        private void ShowError(string text)
        {
            MessageBox.Show(text, Resources.MainForm_ShowError_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HoursComboBox1.SelectedIndex = 12;
            MinutesComboBox1.SelectedIndex = 0;

            HoursComboBox2.SelectedIndex = 12;
            MinutesComboBox2.SelectedIndex = 0;

            HoursComboBox3.SelectedIndex = 12;
            MinutesComboBox3.SelectedIndex = 0;

            SeqNumberComboBox.SelectedIndex = 0;
            DayOfWeekComboBox.SelectedIndex = 0;

            HoursComboBox4.SelectedIndex = 12;
            MinutesComboBox4.SelectedIndex = 0;

            MonthComboBox.SelectedIndex = 0;
            MonthComboBox2.SelectedIndex = 0;

            SeqNumberComboBox2.SelectedIndex = 0;
            DayOfWeekComboBox2.SelectedIndex = 0;

            HoursComboBox5.SelectedIndex = 12;
            MinutesComboBox5.SelectedIndex = 0;
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
