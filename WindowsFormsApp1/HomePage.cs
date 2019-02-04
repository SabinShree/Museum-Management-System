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
    public partial class HomePage : Form
    {
        /// <summary>
        /// Constructor For HomePage Classes.
        /// </summary>
        public HomePage()
        {
            InitializeComponent();
            this.timer1.Start();
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.DateRegular.Text = DateTime.Now.ToString("MMM ddd d HH:mm:ss tt yyyy");
        }

        private void addVisitorButton_Click(object sender, EventArgs e)
        {
            var a  = new AddVisitor();
            a.Show();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RecentlyVisitedButton_Click(object sender, EventArgs e)
        {
            RecentlyVisit recentlyVisited = new RecentlyVisit();
            recentlyVisited.Show();
        }

        private void SearchVisitorButton_Click(object sender, EventArgs e)
        {
            LoginVisitor loginVisitor = new LoginVisitor();
            loginVisitor.Show();
        }

        private void listVisitorTodayButton_Click(object sender, EventArgs e)
        {
            DailyReport daily = new DailyReport();
            daily.Show();
        }

        private void listVisitorWeeklyButton_Click(object sender, EventArgs e)
        {
            WeeklyReport weeklyReport = new WeeklyReport();
            weeklyReport.Show();
        }
    }
}
