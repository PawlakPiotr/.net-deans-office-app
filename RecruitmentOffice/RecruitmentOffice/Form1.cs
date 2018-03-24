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

namespace RecruitmentOffice
{
    public partial class Form1 : Form
    {
        public static List<string> users = new List<string>();
        

        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            listView1.GridLines = true;

            var fileLines = File.ReadAllLines(@"C:\Users\PiotrPawlak\Desktop\stud.txt");

            for (int i = 0; i < fileLines.Length; i++)
            {
                string[] arr = fileLines[i].Split(' ');

                ListViewItem it = new ListViewItem(arr);
                listView1.Items.Add(it);
            }

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem itm = listView1.SelectedItems[i];
                listView1.Items[itm.Index].Remove();
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\PiotrPawlak\Desktop\stud.txt"))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    sw.WriteLine("{0} {1} {2} {3} {4}", 
                        item.SubItems[0].Text, item.SubItems[1].Text,
                        item.SubItems[2].Text, item.SubItems[3].Text,
                        item.SubItems[4].Text
                        );
                }
            }

            this.Close();
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem itm = listView1.SelectedItems[i];
                
            }
        }



    }
}
