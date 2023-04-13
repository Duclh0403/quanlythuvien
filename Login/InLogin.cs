using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class InLogin : Form
    {
        bool isThoat = true;
        public InLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void InLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }
    }
}
