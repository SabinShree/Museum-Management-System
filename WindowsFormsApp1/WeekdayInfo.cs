namespace WindowsFormsApp1
{
    public class WeekdayInfo
    {
        public string weekday { get; set; }
        public string totalVisitor { get; set; }
        public string totalDuration { get; set; }

        public WeekdayInfo(string weekday, string totalVisitor, string totalDuration)
        {
            this.weekday = weekday;
            this.totalVisitor = totalVisitor;
            this.totalDuration = totalDuration;
        }
    }
}