using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeansOffice;

namespace DeansOffice
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;

            SqlServerDB.LoadData();
            SqlServerDB.LoadCurrentTerm();

        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new StudentDialog();
            form.ShowDialog();
        }

        private void EditStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }
        private void RemoveStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sudentForm = new StudentDialog();
            sudentForm.ShowDialog();
        }

        private void StudentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlServerDB.DeleteStudentFromServer();

            if (StudentsDataGridView.CurrentCell != null)
            {
                int rowIndex = StudentsDataGridView.CurrentCell.RowIndex;
                StudentsDataGridView.Rows.RemoveAt(rowIndex);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlServerDB.SearchEngine();
        }

        private void StudentNumberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void LastNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlServerDB.LoadTerm();
        }
    }
}



