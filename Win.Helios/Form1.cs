using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Helios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static DirectoryEntry GetDirectoryEntry()
        {
            DirectoryEntry de = new DirectoryEntry();
            de.Path = "LDAP://192.168.1.1/CN=Users;DC=Yourdomain";
            de.Username = @"idsind\adarsh";
            de.Password = "12345";
            return de;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DirectoryEntry de = GetDirectoryEntry();
            if(txt_UName.Text==de.Username&& txt_PWD.Text==de.Password)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }

        }
    }
}
