using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoProject
{
    public partial class LoginPage : System.Windows.Forms.Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Hello {textBox1.Text}");
            string username = UserId_txt.Text;
            string password = Password_txt.Text;

            if ((this.UserId_txt.Text == "admin") && (this.Password_txt.Text == "admin"))
            {
                this.Hide();
                DataPage frm2 = new DataPage();
                frm2.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Incorrect Password or UserId");
        }
        
        private void Password_txt_TextChanged(object sender, EventArgs e)
        {
            Password_txt.PasswordChar = '●';
            Password_txt.UseSystemPasswordChar = true;
        }
        
        private void LoginPage_Move(object sender, EventArgs e)
        {
            Console.WriteLine("l1 Move");
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            Console.WriteLine("l2 Load");
        }

        private void LoginPage_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine("l3 VisibleChanged");
        }

        private void LoginPage_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("l4 Activated");
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("l8 FormClosing");
        }

        private void LoginPage_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("l6 Paint");
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("l7 FormClosed");
        }

        private void LoginPage_StyleChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("l5 Shown");
        }

        private void LoginPage_Deactivate(object sender, EventArgs e)
        {
            Console.WriteLine("l9 Deactivate");
        }
        
    }
}
