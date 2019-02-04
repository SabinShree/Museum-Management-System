namespace WindowsFormsApp1
{
    public class TotalVisitorInfo
    {
        public string date { get; set; }
        public string totalVisitor { get; set; }
        public string totalTimes { get; set; }

        public TotalVisitorInfo(string date, string totalVisitor, string totalTimes)
        {
            this.date = date;
            this.totalVisitor = totalVisitor;
            this.totalTimes = totalTimes;
        }
    }
}