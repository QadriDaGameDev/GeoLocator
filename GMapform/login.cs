using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMapform
{
    public partial class login : Form
    {
        private int viewButtonClickCount = 0;
        string user = "user";
        string password = "1234";
        public login()
        {
            InitializeComponent();
        }

        private void lgnbtn_Click(object sender, EventArgs e)
            
        {
            if(textBox1.Text== user && textBox2.Text == password)
            {
                MessageBox.Show("Login Successful");               
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("user name or password is incorrect");
            }
                     

                    
        }

        private void lgnbtn_MouseHover(object sender, EventArgs e)
        {
            lgnbtn.BackColor = Color.Orange;
        }

        private void lgnbtn_MouseLeave(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(41, 128, 185);
           lgnbtn.BackColor = customColor;
        }

        private void Register_MouseHover(object sender, EventArgs e)
        {
            Register.BackColor = Color.Orange;
        }

        private void Register_MouseLeave(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(41, 128, 185);
            Register.BackColor = customColor;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            viewButtonClickCount++;
            if (viewButtonClickCount % 2 == 0)
            {
                textBox2.UseSystemPasswordChar = true;

            }
            else
            {
                textBox2.UseSystemPasswordChar =false ;

            }

            
        }

        
    }
}
