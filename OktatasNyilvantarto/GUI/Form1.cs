using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OktatasNyilvantarto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameLbl.Text = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form2 form2 = new Form2();
            Users.Value = listBox1.SelectedItem.ToString();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
