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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void namebtn_MouseHover(object sender, EventArgs e)
        {
            namebtn.BackColor = Color.Orange;
        }    
              

        private void namebtn_MouseLeave_1(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(51, 51, 76);
            namebtn.BackColor = customColor;
        }

        private void contactbtn_MouseHover(object sender, EventArgs e)
        {
            contactbtn.BackColor = Color.Orange;
        }

        private void contactbtn_MouseLeave(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(51, 51, 76);
            contactbtn.BackColor = customColor;
        }

        private void locationbtn_MouseHover(object sender, EventArgs e)
        {
            locationbtn.BackColor = Color.Orange;
        }

        private void locationbtn_MouseLeave(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(51, 51, 76);
           locationbtn.BackColor = customColor;
        }

        private void viewbtn_MouseHover(object sender, EventArgs e)
        {
           viewbtn.BackColor = Color.Orange;
        }

        private void viewbtn_MouseLeave(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(51, 51, 76);
            viewbtn.BackColor = customColor;
        }
    }
}
