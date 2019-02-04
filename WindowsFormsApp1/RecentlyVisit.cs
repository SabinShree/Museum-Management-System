using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RecentlyVisit : Form
    {
        public const string OUT_VISITOR = @"C:\C# projects\WindowsFormsApp1\WindowsFormsApp1\CsvFile\OutVisitor.csv";

        public RecentlyVisit()
        {
            InitializeComponent();
        }

        private void LoadDataToTable()
        {
            List<Visitor> visitorsList = ReadFromCsv.ReadFromCsvToList(AddVisitor.uncheckedVisitorPath);
            foreach (var visitor in visitorsList)
            {
                visitorBindingSource.Add(new Visitor(visitor.cardNumber, visitor.name, visitor.contactNo,
                    visitor.address, visitor.occupation, visitor.inTimeDate, visitor.day, visitor.inTimeExact,
                    visitor.outTimeExact, visitor.totalTime));
            }
        }

        /// <summary>
        /// Searching information using various parameter.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="visitors"></param>
        /// <param name="remove"></param>
        /// <param name="add"></param>
        /// <param name="cardNumber"></param>
        public static void ManipulateData(string path, Visitor visitors)
        {
            var visitorsList = ReadFromCsv.ReadFromCsvToList(path);
            File.WriteAllText(AddVisitor.uncheckedVisitorPath, string.Empty);

            var visitorsListSorted = sortList(visitorsList);
            int found = binarySearchList(visitorsListSorted, visitors);
            if (found >= 0)
            {
                visitorsListSorted.Remove(visitorsListSorted[found]);
            }

            if (!File.Exists(AddVisitor.uncheckedVisitorPath)) return;
            using (var streamWriter = new StreamWriter(AddVisitor.uncheckedVisitorPath, true))
            {
                streamWriter.WriteLine(
                    "cardNumber,name,contactNo,address,occupation,inTime,day,inTimeExact,outTimeExact,totalTime");
                foreach (var visitor in visitorsListSorted)
                {
                    streamWriter.WriteLine(visitor
                        .ToString());
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visitor"></param>
        private static void ExitVisitorInformation(Visitor visitor)
        {
            if (!File.Exists(OUT_VISITOR))
            {
                using (var streamWriter = new StreamWriter(OUT_VISITOR, true))
                {
                    streamWriter.WriteLine(
                        "cardNumber,name,contactNo,address,occupation,inTime,day,inTimeExact,outTimeExact,totalTime");
                    streamWriter.WriteLine(visitor);
                }
            }
            else
            {
                using (var streamWriter = new StreamWriter(OUT_VISITOR, true))
                {
                    streamWriter.WriteLine(visitor);
                }
            }
        }

        public static List<Visitor> sortList(List<Visitor> visitorLists)
        {
            for (var i = 0; i < visitorLists.Count - 1; i++)
            {
                for (int j = i + 1; j < visitorLists.Count; j++)
                {
                    if (visitorLists[i].cardNumber > visitorLists[j].cardNumber)
                    {
                        Visitor temp = visitorLists[i];
                        visitorLists[i] = visitorLists[j];
                        visitorLists[j] = temp;
                    }
                }
            }

            return visitorLists;
        }


        public static int binarySearchList(List<Visitor> visitorList, Visitor visitor)
        {
            int shorestPath = 0;

            int longestPath = visitorList.Count - 1;
            while (shorestPath <= longestPath)
            {
                var m = (shorestPath + longestPath) / 2;
                if (visitorList[m].cardNumber < visitor.cardNumber)
                {
                    shorestPath = m + 1;
                }
                else if (visitorList[m].cardNumber > visitor.cardNumber)
                {
                    longestPath = m - 1;
                }
                else
                {
                    return m;
                }
            }

            return -1;
        }

        private void RecentlyVisit_Load(object sender, EventArgs e)
        {
            LoadDataToTable();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "OutTime")
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    string cardNumber = row.Cells[0].Value.ToString();
                    string name = row.Cells[1].Value.ToString();
                    string contactNumber = row.Cells[2].Value.ToString();
                    string address = row.Cells[3].Value.ToString();
                    string occupation = row.Cells[4].Value.ToString();
                    string inTimeDateStr = row.Cells[5].Value.ToString();
                    string day = row.Cells[6].Value.ToString();
                    string inTime = row.Cells[7].Value.ToString();
                    DateTime dateTime = DateTime.Now;
                    string outTime = dateTime.ToString("t");
                    DateTime inTimeDate = DateTime.ParseExact(inTime, "h:mm tt", CultureInfo.InvariantCulture);
                    DateTime outTimeDate = DateTime.Parse(outTime);
                    string totalTimeDate = "" + outTimeDate.Subtract(inTimeDate).TotalMinutes;
                    Visitor visitor = new Visitor(int.Parse(cardNumber), name, int.Parse(contactNumber), address,
                        occupation, inTime, day, inTimeDateStr, outTime, totalTimeDate);
                    Console.WriteLine(visitor);
                    ExitVisitorInformation(visitor);
                    ManipulateData(AddVisitor.uncheckedVisitorPath, visitor);
                }

                visitorBindingSource.RemoveCurrent();
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "DeleteVisitor")
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    string cardNumber = row.Cells[0].Value.ToString();
                    string name = row.Cells[1].Value.ToString();
                    string contactNumber = row.Cells[2].Value.ToString();
                    string address = row.Cells[3].Value.ToString();
                    string occupation = row.Cells[4].Value.ToString();
                    string inTimeDateStr = row.Cells[5].Value.ToString();
                    string day = row.Cells[6].Value.ToString();
                    string inTime = row.Cells[7].Value.ToString();
                    DateTime dateTime = DateTime.Now;
                    string outTime = dateTime.ToString("t");
                    DateTime inTimeDate = DateTime.ParseExact(inTime, "hh:mm tt", CultureInfo.InvariantCulture);
                    DateTime outTimeDate = DateTime.Parse(outTime);
                    string totalTimeDate = "" + outTimeDate.Subtract(inTimeDate).TotalMinutes;
                    Visitor visitor = new Visitor(int.Parse(cardNumber), name, int.Parse(contactNumber), address,
                        occupation, inTime, day, inTimeDateStr, outTime, totalTimeDate);
                    Console.WriteLine(visitor);
                    ManipulateData(AddVisitor.uncheckedVisitorPath, visitor);
                }
            }
        }
    }
}