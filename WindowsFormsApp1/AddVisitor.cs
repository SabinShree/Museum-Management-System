using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <inheritdoc />
    public partial class AddVisitor : Form
    {
        private List<Visitor> _visitors = new List<Visitor>();

        public static string uncheckedVisitorPath =
            @"C:\C# projects\WindowsFormsApp1\WindowsFormsApp1\CsvFile\recentlyVisited.csv";

        /// <summary>
        /// Constructor For Add Visitor.
        /// </summary>
        public AddVisitor()
        {
            InitializeComponent();
        }

        private void generateRandomButton_Click(object sender, EventArgs e)
        {
            GenerateRandomNumberForCardNumber();
        }

        private void GenerateRandomNumberForCardNumber()
        {
            var random = new Random();
            this.cardNumberText.Text = (random.Next(1000, 9999)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string cardNumber = cardNumberText.Text.Trim();
            string name = nameText.Text.Trim();
            string contactNumber = contactText.Text.Trim();
            string address = addressText.Text.Trim();
            string occupation = OccupationText.Text.Trim();

            if (cardNumber.Length <= 0 || name.Length <= 0 || contactNumber.Length <= 0 || address.Length <= 0 ||
                occupation.Length <= 0)
            {
                MessageBox.Show("Text is not filled properly", "Error !");
                return;
            }

            int contactNumberInt = 0;
            try
            {
                contactNumberInt = int.Parse(contactNumber);
            }
            catch
            {
                MessageBox.Show("Invalid data inserted at contact number", "Error");
                return;
            }


            try
            {
                var uncheckedVisitorPath =
                    @"C:\C# projects\WindowsFormsApp1\WindowsFormsApp1\CsvFile\recentlyVisited.csv";

                IEnumerable<Visitor> lists = ReadFromCsv.ReadFromCsvToList(uncheckedVisitorPath);
                foreach (var list in lists)
                {
                    if (list.cardNumber == int.Parse(cardNumber))
                        throw new Exception();
                }
            }
            catch (Exception ke)
            {
                DialogResult dialogResult = MessageBox.Show("Card number matches\nDo you want to regenerate it ? ",
                    "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GenerateRandomNumberForCardNumber();
                }
                else return;
            }

            cardNumber = cardNumberText.Text.Trim();
            string day = DateTime.Now.DayOfWeek.ToString();
            string inTimeDate = DateTime.Now.ToString("yyyy MMMM dd");
            string inTimeExact = DateTime.Now.ToString("t");
            TimeSpan start = TimeSpan.Parse("17:00"); // 5 PM
            TimeSpan end = TimeSpan.Parse("10:00"); // 10 AM
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (day == DayOfWeek.Monday.ToString() || day == DayOfWeek.Tuesday.ToString() || day ==
                DayOfWeek.Wednesday.ToString() || day == DayOfWeek.Thursday.ToString() ||
                day == DayOfWeek.Friday.ToString())
            {
                if ((now < start) && (now > end))
                {
            var visitor = new Visitor(int.Parse(cardNumber), name, contactNumberInt, address, occupation,
                inTimeDate,
                day, inTimeExact, "-", "-");
            WriteListToCsv(visitor);
            ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Museum is now closed. come between 10 to 5", "Sorry");
                }
            }
        }


        public static void WriteListToCsv(Visitor lists)
        {
            if (!File.Exists(uncheckedVisitorPath))
            {
                using (var streamWriter = new StreamWriter(uncheckedVisitorPath, true))
                {
                    streamWriter.WriteLine(
                        "cardNumber,name,contactNo,address,occupation,inTime,day,inTimeExact,outTimeExact,totalTime");
                    streamWriter.WriteLine(lists
                        .ToString());
                    MessageBox.Show("Added : " + lists.name, "New visitor added.");
                }
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(uncheckedVisitorPath, true))
                {
                    streamWriter.WriteLine(lists.ToString());
                    MessageBox.Show("Added : " + lists.name, "New visitor added.");
                }
            }
        }


        private void ClearTextBox()
        {
            cardNumberText.Text = "";
            nameText.Text = "";
            contactText.Text = "";
            addressText.Text = "";
            OccupationText.Text = "";
        }
    }
}