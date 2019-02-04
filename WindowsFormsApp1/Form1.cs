using Newtonsoft.Json;
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
    /// <summary>
    /// Main Form to login.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void login_Click(object sender, EventArgs e)
        {
            var userName = userNameText.Text.Trim();
            var password = passwordText.Text.Trim();
            var jsonObject =
                JsonConvert.DeserializeObject<Login>(
                    File.ReadAllText(@"C:\C# projects\WindowsFormsApp1\WindowsFormsApp1\admin.json"));
            if (userName.Length >= 0 && password.Length >= 0)
            {
                if (userName.Equals(jsonObject.userName) && password.Equals(jsonObject.password))
                {
                    invalid.Visible = false;
                    MessageBox.Show("Login successfull", "Success");
                    this.Hide();
                    var homePage = new HomePage();
                    homePage.Show();
                }
                else
                    invalid.Visible = true;
            }
            else invalid.Visible = true;
        }
    }
}