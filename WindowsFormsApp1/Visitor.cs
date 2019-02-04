using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Visitor class created Which add the visitor to the csv file.
    /// </summary>
    public class Visitor
    {
        public int cardNumber { get; set; }
        public string name { get; set; }
        public int contactNo { get; set; }
        public string address { get; set; }
        public string occupation { get; set; }
        public string inTimeDate { get; set; }
        public string inTimeExact { get; set; }
        public string outTimeExact { get; set; }
        public string day { get; set; }
        public string totalTime { get; set; }

        /// <summary>
        /// Constructor of Visitor class. 
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <param name="name"></param>
        /// <param name="contactNo"></param>
        /// <param name="address"></param>
        /// <param name="occupation"></param>
        /// <param name="inTime"></param>
        /// <param name="day"></param>
        /// <param name="inTimeExact"></param>
        /// <param name="outTime"></param>
        /// <param name="totalTime"></param>
        public Visitor(int cardNumber, string name, int contactNo, string address, string occupation, string inTimeDate,
            string day, string inTimeExact,
            string outTime, string totalTime
        )
        {
            this.cardNumber = cardNumber;
            this.name = name;
            this.contactNo = contactNo;
            this.day = day;
            this.inTimeExact = inTimeExact;
            this.address = address;
            this.occupation = occupation;
            this.inTimeDate = inTimeDate;
            this.outTimeExact = outTime;
            this.totalTime = totalTime;
        }

        /// <summary>
        /// Overriding to string method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.cardNumber + "," + this.name + "," + this.contactNo + "," + this.address + "," +
                   this.occupation + "," + this.inTimeDate + "," + this.day + "," + this.inTimeExact + "," +
                   this.outTimeExact + "," + this.totalTime;
        }

//        public Visitor(string item)
//        {
//            var itemSplit = item.Split(',');
//            this.cardNumber = int.Parse(itemSplit[0]);
//            this.name = itemSplit[1];
//            this.contactNo = itemSplit[2];
//            this.address = itemSplit[3];
//            this.occupation = itemSplit[4];
//            this.inTime = itemSplit[5];
//            this.outTime = itemSplit[6];
//            this.totalTime = itemSplit[7];
//        }
    }
}