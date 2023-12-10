using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("datax.txt");
            file.WriteLine("Name: " + txtname.Text);
            file.WriteLine("age: " + txtage.Text);
           
            if (rm.Checked)
                file.WriteLine("Gender: Male");
            else file.WriteLine("Gender: Female");
            file.WriteLine("Address: " + cmbx.Text);
            string chkstring = "";
            bool first_element = true;
            foreach (var chk in chklist.CheckedItems)
            {
                if (first_element)
                    chkstring += chk;
                else chkstring += " - " + chk;
                first_element = false;
            }
            
            file.WriteLine("Courses: " + chkstring);
           // file.Flush();
            file.Close();
            string s = txtname.Text;
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
