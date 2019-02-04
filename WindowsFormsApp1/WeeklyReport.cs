using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WeeklyReport : Form
    {
        public WeeklyReport()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string choosenDate = this.fromDate.Value.ToString("yyyy MMMM dd");
            DateTime date = DateTime.Parse(choosenDate);
            //get year from the date
            int year = date.Date.Year;
            //set the first day of the year
            DateTime firstDay = new DateTime(year, 1, 1);
            // MessageBox.Show(year + ", " + date.Month + " " + date.Day);
            //get Day of the week 
            DayOfWeek day = date.DayOfWeek;
            CultureInfo cul = CultureInfo.CurrentCulture;
            //get no of week for the date
            int weekNo = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
            //get no of day
            int days = (weekNo - 1) * 7;
            DateTime dt1 = firstDay.AddDays(days);
            DayOfWeek dow = dt1.DayOfWeek;
            DateTime startDateOfWeek = dt1.AddDays(-(int) dow);
            DateTime endDateOfWeek = startDateOfWeek.AddDays(6);

            string startDateOfWeekChoosen = startDateOfWeek.ToString("yyyy MMMM dd");
            string endDateOfWeekChoosen = endDateOfWeek.ToString("yyyy MMMM dd");
            List<Visitor> listVisitor = ReadFromCsv.ReadFromCsvToList(RecentlyVisit.OUT_VISITOR);
            List<Visitor> choosenWeekVisitor = new List<Visitor>();
            listVisitor = listVisitor.GroupBy(p => p.cardNumber).Select(group => group.First()).ToList();

            foreach (var visitor in listVisitor)
            {
                if (DateTime.Parse(visitor.inTimeExact) >= startDateOfWeek &&
                    DateTime.Parse(visitor.inTimeExact) <= endDateOfWeek)
                {
                    choosenWeekVisitor.Add(visitor);
                }
            }

            var totalVisitorInAWeek = choosenWeekVisitor.Count;
            this.totalVisitorLabel.Visible = true;
            this.label2.Visible = true;
            this.totalVisitorLabel.Text =
                startDateOfWeekChoosen + " to " + endDateOfWeekChoosen + " are " + totalVisitorInAWeek;
            List<WeekdayInfo> weekdayInfosLists = new List<WeekdayInfo>();
            int[] totalVisitor = new int[5];
            int[] totalMinutes = new int[5];
            foreach (var chosenVisitor in choosenWeekVisitor)
            {
                if (chosenVisitor.day == DayOfWeek.Monday.ToString())
                {
                    totalVisitor[0]++;
                    totalMinutes[0] += int.Parse(chosenVisitor.totalTime);
                }
                else if (chosenVisitor.day == DayOfWeek.Tuesday.ToString())
                {
                    totalVisitor[1]++;
                    totalMinutes[1] += int.Parse(chosenVisitor.totalTime);
                }
                else if (chosenVisitor.day == DayOfWeek.Wednesday.ToString())
                {
                    totalVisitor[2]++;
                    totalMinutes[2] += int.Parse(chosenVisitor.totalTime);
                }
                else if (chosenVisitor.day == DayOfWeek.Thursday.ToString())
                {
                    totalVisitor[3]++;
                    totalMinutes[3] += int.Parse(chosenVisitor.totalTime);
                }
                else if (chosenVisitor.day == DayOfWeek.Friday.ToString())
                {
                    totalVisitor[4]++;
                    totalMinutes[4] += int.Parse(chosenVisitor.totalTime);
                }
            }

            foreach (var chosenVisitor in choosenWeekVisitor)
            {
                if (chosenVisitor.day == DayOfWeek.Monday.ToString())
                {
                    weekdayInfosLists.Add(
                        new WeekdayInfo(chosenVisitor.day, "" + totalVisitor[0], "" + totalMinutes[0]));
                }
                else if (chosenVisitor.day == DayOfWeek.Tuesday.ToString())
                {
                    weekdayInfosLists.Add(
                        new WeekdayInfo(chosenVisitor.day, "" + totalVisitor[1], "" + totalMinutes[1]));
                }
                else if (chosenVisitor.day == DayOfWeek.Wednesday.ToString())
                {
                    weekdayInfosLists.Add(
                        new WeekdayInfo(chosenVisitor.day, "" + totalVisitor[2], "" + totalMinutes[2]));
                }
                else if (chosenVisitor.day == DayOfWeek.Thursday.ToString())
                {
                    weekdayInfosLists.Add(
                        new WeekdayInfo(chosenVisitor.day, "" + totalVisitor[3], "" + totalMinutes[4]));
                }
                else if (chosenVisitor.day == DayOfWeek.Friday.ToString())
                {
                    weekdayInfosLists.Add(
                        new WeekdayInfo(chosenVisitor.day, "" + totalVisitor[4], "" + totalMinutes[4]));
                }
            }

            weekdayInfosLists = weekdayInfosLists.GroupBy(p => p.weekday).Select(group => group.First()).ToList();
            this.weekdayInfoBindingSource.Clear();
            sortList(weekdayInfosLists);

            foreach (var weekdayData in weekdayInfosLists)
            {
                this.weekdayInfoBindingSource.Add(new WeekdayInfo(weekdayData.weekday, weekdayData.totalVisitor,
                    weekdayData.totalDuration));
            }

            this.chart1.Series["totalVisitor"].Points.Clear();
            this.chart1.Series["totalDuration"].Points.Clear();

            foreach (var weekdayInBar in weekdayInfosLists)
            {
                this.chart1.Series["totalVisitor"].Points.AddXY(weekdayInBar.weekday, weekdayInBar.totalVisitor);
                this.chart1.Series["totalDuration"].Points.AddXY(weekdayInBar.weekday, weekdayInBar.totalDuration);
            }
        }

        public static void sortList(List<WeekdayInfo> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (int.Parse(list[j].totalVisitor) > int.Parse(list[j + 1].totalVisitor))
                    {
                        var temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
    }
}