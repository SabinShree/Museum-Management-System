using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DailyReport : Form
    {
        public DailyReport()
        {
            InitializeComponent();
        }

        private void generateButtonReport_Click(object sender, EventArgs e)
        {
            string choosedDate = dateTimePicker.Value.ToString("yyyy MMMM dd");
            int totalVisitor = 0;
            string exactTime = null;
            int totalTimeVisited = 0;
            List<Visitor> outVisitorList = ReadFromCsv.ReadFromCsvToList(RecentlyVisit.OUT_VISITOR);
            foreach (var visitor in outVisitorList)
            {
                if (visitor.inTimeExact != choosedDate) continue;
                exactTime = visitor.inTimeExact;
                totalVisitor++;
                totalTimeVisited += int.Parse(visitor.totalTime);
            }

            this.chart1.Series["Total visitor visited"].Points.Clear();
            this.chart1.Series["Total visitor visited"].Points.AddXY("Visitor", totalVisitor);
            totalVisitorInfoBindingSource.Clear();
            totalVisitorInfoBindingSource.Add(new TotalVisitorInfo(exactTime, "" + totalVisitor,
                "" + totalTimeVisited));
            List<Visitor> individualDataList = individualData(choosedDate);
            List<TotalVisitorInfo> totalVisitorInfos = new List<TotalVisitorInfo>();
            for (int i = 0; i < individualDataList.Count; i++)
            {
                totalVisitorInfos.Add(new TotalVisitorInfo(individualDataList[i].inTimeDate, individualDataList[i].name,
                    individualDataList[i].totalTime));
            }
            totalVisitorInfoBindingSource1.Clear();
            for (int i = 0; i < totalVisitorInfos.Count; i++)
            {
                totalVisitorInfoBindingSource1.Add(new TotalVisitorInfo(totalVisitorInfos[i].date,
                    totalVisitorInfos[i].totalVisitor, totalVisitorInfos[i].totalTimes));
            }
        }

        public List<Visitor> individualData(string choosedDate)
        {
            List<Visitor> list = new List<Visitor>();
            List<Visitor> outVisitorList = ReadFromCsv.ReadFromCsvToList(RecentlyVisit.OUT_VISITOR);
            foreach (var visitor in outVisitorList)
            {
                if (visitor.inTimeExact == choosedDate)
                {
                    list.Add(visitor);
                }
            }
            return list;
        }
    }
}