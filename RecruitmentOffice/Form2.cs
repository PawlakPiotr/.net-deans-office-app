using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentOffice
{
    public partial class Form2 : Form
    {
        

        private Boolean 
            if_NAME_Changed = false,
            if_SURNAME_Changed = false,
            if_DATE_isRight = false,
            if_PESEL_Changed = false,
            if_MAIL_hasAt = false;

        Color farbe;
        static string date_validation = "dd/mm/yyyy";

        public Form2()
        {
            InitializeComponent();
            
            this.ControlBox = false;
            this.Text = String.Empty;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            button1.Enabled = false;


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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            farbe = textBox3.ForeColor;

            textBox3.GotFocus += RemoveText;
            textBox3.LostFocus += AddText;

            textBox3.ForeColor = Color.Gray;
            textBox3.Text = date_validation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text};
            var listViewItem = new ListViewItem(row);

            Form1.listView1.Items.Add(listViewItem);
            
            this.Close();
        }

        // Imie kandydata
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length >= 2)
            {
                if_NAME_Changed = true;
                validateInformation();
            }
            else
            {
                button1.Enabled = false;
            }
        }

        // Nazwisko kandydata
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 2)
            {
                if_SURNAME_Changed = true;
                validateInformation();
            }
            else
            {
                button1.Enabled = false;
            }
        }

        // Data urodzenia kandydata
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"(^(((0[1-9]|1[0-9]|2[0-8])[\/](0[1-9]|1[012]))|((29|30|31)[\/](0[13578]|1[02]))|((29|30)[\/](0[4,6,9]|11)))[\/](19|[2-9][0-9])\d\d$)|(^29[\/]02[\/](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)");
            Match m = reg.Match(textBox3.Text);
            if (m.Success)
            {
               if_DATE_isRight = true;
                validateInformation();
            }
            else
            {
                button1.Enabled = false;
            }
            
        }

        // PESEL kandydata
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.Text.Length == 11 &&
                isDigitPESEL(textBox4))
            {
                if_PESEL_Changed = true;
                validateInformation();
            }
            else
            {
                button1.Enabled = false;
                
            }
            
        }
       
        // Adres email kandydata
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Contains("@"))
            {
                if_MAIL_hasAt = true;
                validateInformation();

            }
            else
            {
                button1.Enabled = false;  
            }
        }

        //Placeholder do daty
        public void RemoveText(object sender, EventArgs e)
        {
            textBox3.ForeColor = farbe;
            if (textBox3.Text == date_validation)
                textBox3.Text = "";
        }
        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.ForeColor = Color.Gray;
                textBox3.Text = date_validation;
            }
        }

        //textBox - validation
        private void validateInformation()
        {
            if (if_DATE_isRight &&
                          if_SURNAME_Changed &&
                          if_NAME_Changed &&
                          if_PESEL_Changed &&
                          if_MAIL_hasAt)
            {
                button1.Enabled = true;
            }
        }
        private bool isDigitPESEL(TextBox tx)
        {
            bool isDigit = false;
            char[] arr = tx.Text.ToCharArray();
           
            
           if (char.IsDigit(arr[0]) && char.IsDigit(arr[1]) &&
               char.IsDigit(arr[2]) && char.IsDigit(arr[3]) &&
               char.IsDigit(arr[4]) && char.IsDigit(arr[5]) &&
               char.IsDigit(arr[6]) && char.IsDigit(arr[7]) &&
               char.IsDigit(arr[8]) && char.IsDigit(arr[9]) &&
               char.IsDigit(arr[10]))
           {
                    isDigit = true;
           }
            

            return isDigit;
        }
    }

}
