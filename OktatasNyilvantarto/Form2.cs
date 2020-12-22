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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Value;
            using (var db = new DolgozoiKodok())
            {
                var query = from dk in db.DolgKodok
                            orderby dk.TextDescription
                            where dk.StatusAkt == 1
                            select new { dk.TSz, dk.TextDescription };
                foreach (var a in query)
                {
                    nameList.Items.Add(a.TextDescription + "#" + a.TSz);
                }
            }
        }
        public string Value { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (partList.Items.Count > 0)
            {
                for (int i = 0; i < partList.Items.Count; i++)
                {
                    if (partList.Items[i] == nameList.SelectedItem)
                    {
                        a++;
                    }
                }
                if (a == 0)
                {
                   partList.Items.Add(nameList.SelectedItem);
                }
            }
            else 
            {
                partList.Items.Add(nameList.SelectedItem);
            }
        }

        private void partList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            partList.Items.Remove(partList.SelectedItem);
        }
    }
}
