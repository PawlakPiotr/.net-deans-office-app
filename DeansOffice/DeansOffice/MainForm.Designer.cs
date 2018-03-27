namespace DeansOffice
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SearchPanel = new System.Windows.Forms.Panel();
            StudentNumberCheckBox = new System.Windows.Forms.CheckBox();
            LastNameCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SemesterPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SemesterLabel = new System.Windows.Forms.Label();
            SemesterComboBox = new System.Windows.Forms.ComboBox();
            StudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.GridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SemesterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(StudentsDataGridView)).BeginInit();
            this.GridViewContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(StudentNumberCheckBox);
            this.SearchPanel.Controls.Add(LastNameCheckBox);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(textBox1);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(0, 33);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(814, 86);
            this.SearchPanel.TabIndex = 0;
            // 
            // StudentNumberCheckBox
            // 
            StudentNumberCheckBox.AutoSize = true;
            StudentNumberCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            StudentNumberCheckBox.Location = new System.Drawing.Point(569, 28);
            StudentNumberCheckBox.Margin = new System.Windows.Forms.Padding(2);
            StudentNumberCheckBox.Name = "StudentNumberCheckBox";
            StudentNumberCheckBox.Size = new System.Drawing.Size(207, 33);
            StudentNumberCheckBox.TabIndex = 3;
            StudentNumberCheckBox.Text = "Indeks studenta";
            StudentNumberCheckBox.UseVisualStyleBackColor = true;
            StudentNumberCheckBox.CheckedChanged += new System.EventHandler(this.StudentNumberCheckBox_CheckedChanged);
            // 
            // LastNameCheckBox
            // 
            LastNameCheckBox.AutoSize = true;
            LastNameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            LastNameCheckBox.Location = new System.Drawing.Point(406, 28);
            LastNameCheckBox.Margin = new System.Windows.Forms.Padding(2);
            LastNameCheckBox.Name = "LastNameCheckBox";
            LastNameCheckBox.Size = new System.Drawing.Size(143, 33);
            LastNameCheckBox.TabIndex = 2;
            LastNameCheckBox.Text = "Nazwisko";
            LastNameCheckBox.UseVisualStyleBackColor = true;
            LastNameCheckBox.CheckedChanged += new System.EventHandler(this.LastNameCheckBox_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchButton.Location = new System.Drawing.Point(217, 24);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(125, 40);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Szukaj";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            textBox1.Location = new System.Drawing.Point(19, 24);
            textBox1.Margin = new System.Windows.Forms.Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(194, 35);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(814, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.FileToolStripMenuItem.Text = "Plik";
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.CloseToolStripMenuItem.Text = "Zamknij";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.ReportsToolStripMenuItem.Text = "Raporty";
            // 
            // SemesterPanel
            // 
            this.SemesterPanel.Controls.Add(this.button1);
            this.SemesterPanel.Controls.Add(this.button2);
            this.SemesterPanel.Controls.Add(this.SemesterLabel);
            this.SemesterPanel.Controls.Add(SemesterComboBox);
            this.SemesterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SemesterPanel.Location = new System.Drawing.Point(0, 432);
            this.SemesterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SemesterPanel.Name = "SemesterPanel";
            this.SemesterPanel.Size = new System.Drawing.Size(814, 93);
            this.SemesterPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(616, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Usuń studenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(406, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Dodaj studenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SemesterLabel.Location = new System.Drawing.Point(14, 32);
            this.SemesterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(103, 29);
            this.SemesterLabel.TabIndex = 1;
            this.SemesterLabel.Text = "Semestr";
            // 
            // SemesterComboBox
            // 
            SemesterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            SemesterComboBox.FormattingEnabled = true;
            SemesterComboBox.Location = new System.Drawing.Point(119, 30);
            SemesterComboBox.Margin = new System.Windows.Forms.Padding(2);
            SemesterComboBox.Name = "SemesterComboBox";
            SemesterComboBox.Size = new System.Drawing.Size(260, 37);
            SemesterComboBox.TabIndex = 0;
            SemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.SemesterComboBox_SelectedIndexChanged);
            // 
            // StudentsDataGridView
            // 
            StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            StudentsDataGridView.Location = new System.Drawing.Point(0, 119);
            StudentsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            StudentsDataGridView.Name = "StudentsDataGridView";
            StudentsDataGridView.RowTemplate.Height = 33;
            StudentsDataGridView.Size = new System.Drawing.Size(814, 313);
            StudentsDataGridView.TabIndex = 3;
            StudentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataGridView_CellContentClick);
            // 
            // GridViewContextMenuStrip
            // 
            this.GridViewContextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.GridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStudentToolStripMenuItem,
            this.EditStudentToolStripMenuItem,
            this.RemoveStudentToolStripMenuItem});
            this.GridViewContextMenuStrip.Name = "GridViewContextMenuStrip";
            this.GridViewContextMenuStrip.Size = new System.Drawing.Size(208, 94);
            // 
            // AddStudentToolStripMenuItem
            // 
            this.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem";
            this.AddStudentToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.AddStudentToolStripMenuItem.Text = "Dodaj studenta";
            this.AddStudentToolStripMenuItem.Click += new System.EventHandler(this.AddStudentToolStripMenuItem_Click);
            // 
            // EditStudentToolStripMenuItem
            // 
            this.EditStudentToolStripMenuItem.Name = "EditStudentToolStripMenuItem";
            this.EditStudentToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.EditStudentToolStripMenuItem.Text = "Edytuj studenta";
            this.EditStudentToolStripMenuItem.Click += new System.EventHandler(this.EditStudentToolStripMenuItem_Click);
            // 
            // RemoveStudentToolStripMenuItem
            // 
            this.RemoveStudentToolStripMenuItem.Name = "RemoveStudentToolStripMenuItem";
            this.RemoveStudentToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.RemoveStudentToolStripMenuItem.Text = "Usuń studenta";
            this.RemoveStudentToolStripMenuItem.Click += new System.EventHandler(this.RemoveStudentToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 525);
            this.Controls.Add(StudentsDataGridView);
            this.Controls.Add(this.SemesterPanel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Aplikacja dziekanat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SemesterPanel.ResumeLayout(false);
            this.SemesterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(StudentsDataGridView)).EndInit();
            this.GridViewContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        public static System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchButton;
        public static System.Windows.Forms.CheckBox LastNameCheckBox;
        public static System.Windows.Forms.CheckBox StudentNumberCheckBox;
        private System.Windows.Forms.Panel SemesterPanel;
        private System.Windows.Forms.Label SemesterLabel;
        public static System.Windows.Forms.ComboBox SemesterComboBox;
        private System.Windows.Forms.ContextMenuStrip GridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveStudentToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public static System.Windows.Forms.DataGridView StudentsDataGridView;
    }
}

