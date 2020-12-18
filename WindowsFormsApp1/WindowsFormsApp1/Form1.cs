using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static string Reverse (string reverse)
        {
            char[] n= reverse.ToArray();
            Array.Reverse(n);
            return new string(n);
        }
        private void btnReverse_Click(object sender, EventArgs e)
        {
            string a = textint1.Text;
            lbl1.Text = Reverse(a);
            if (a == "")
            {
                MessageBox.Show("Tolong isi Text box!!");
            }
        }
        private static string Urut (string urutkan)
        {
            char[] n = urutkan.ToArray();
            Array.Sort(n);          
            return new string(n);
        }       
        private void btnUrut_Click(object sender, EventArgs e)
        {
            string a = textint1.Text;
            lbl1.Text = Urut(a);
            if(a == "")
            {
                MessageBox.Show("Tolong isi Text box!!");
            }
        }
    }
}
