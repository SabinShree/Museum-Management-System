using System;

namespace WindowsFormsApp1
{
    public class IndividualPersonData
    {
        public string name { get; set; }
        public string totalDuration { get; set; }

        public IndividualPersonData(string name, string totalDuration)
        {
            this.name = name;
            this.totalDuration = totalDuration;
        }
        
    }
}