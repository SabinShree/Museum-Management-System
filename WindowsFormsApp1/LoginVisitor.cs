using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginVisitor : Form
    {
        public LoginVisitor()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            const string OUT_VISITOR = @"C:\C# projects\WindowsFormsApp1\WindowsFormsApp1\CsvFile\OutVisitor.csv";

            string cardNumberText = cardNumberTextField.Text.Trim();
            Visitor visitor = null;
            List<Visitor> listVisitor = ReadFromCsv.ReadFromCsvToList(OUT_VISITOR);
            listVisitor = RecentlyVisit.sortList(listVisitor);

            for (int i = 0; i < listVisitor.Count; i++)
            {
                if (listVisitor[i].cardNumber == int.Parse(cardNumberText))
                {
                    visitor = listVisitor[i];
                    break;
                }
            }

            if (visitor != null)
            {
                visitor.inTimeDate = DateTime.Now.ToString("yyyy MMMM dd");
                visitor.inTimeExact = DateTime.Now.ToString("t");
                visitor.outTimeExact = "-";
                visitor.totalTime = "-";
                AddVisitor.WriteListToCsv(visitor);
                MessageBox.Show(visitor.name + " is added.", "Added");
            }
            else
            {
                DialogResult dialogResult =
                    MessageBox.Show("Not found this card number. Want to regiter with new users ?  ", "No Result",
                        MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AddVisitor addVisitor = new AddVisitor();
                    addVisitor.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    // keeping this for further use.
                }
            }
        }
    }
}