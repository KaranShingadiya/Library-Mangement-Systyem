namespace LIBRARY_MANAGEMENT_SYSTEM
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btnCompleteBooksDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturnBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btnIssuedBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uC_AddStudent1 = new LIBRARY_MANAGEMENT_SYSTEM.Library.UC_AddStudent();
            this.uC_ViewStudent1 = new LIBRARY_MANAGEMENT_SYSTEM.Library.UC_ViewStudent();
            this.uC_AddBook1 = new LIBRARY_MANAGEMENT_SYSTEM.Library.UC_AddBook();
            this.uC_ViewBooks1 = new LIBRARY_MANAGEMENT_SYSTEM.UC_ViewBooks();
            this.uC_IssueBooks1 = new LIBRARY_MANAGEMENT_SYSTEM.Library.UC_IssueBooks();
            this.uC_ReturnBook1 = new LIBRARY_MANAGEMENT_SYSTEM.Library.UC_ReturnBook();
            this.uC_CompleteBookDetails1 = new LIBRARY_MANAGEMENT_SYSTEM.Library.UC_CompleteBookDetails();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.btnAddBooks);
            this.panel1.Controls.Add(this.btnViewBooks);
            this.panel1.Controls.Add(this.btnCompleteBooksDetails);
            this.panel1.Controls.Add(this.btnReturnBooks);
            this.panel1.Controls.Add(this.btnIssuedBooks);
            this.panel1.Controls.Add(this.btnViewStudent);
            this.panel1.Controls.Add(this.btnAddStudent);
            this.panel1.Location = new System.Drawing.Point(41, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 102);
            this.panel1.TabIndex = 0;
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnAddBooks.BorderRadius = 26;
            this.btnAddBooks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddBooks.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddBooks.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBooks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnAddBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooks.ForeColor = System.Drawing.Color.White;
            this.btnAddBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBooks.Image")));
            this.btnAddBooks.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddBooks.Location = new System.Drawing.Point(365, 12);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(159, 75);
            this.btnAddBooks.TabIndex = 6;
            this.btnAddBooks.Text = "Add Books";
            this.btnAddBooks.TextOffset = new System.Drawing.Point(3, 0);
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // btnViewBooks
            // 
            this.btnViewBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnViewBooks.BorderRadius = 26;
            this.btnViewBooks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewBooks.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewBooks.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewBooks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnViewBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooks.ForeColor = System.Drawing.Color.White;
            this.btnViewBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnViewBooks.Image")));
            this.btnViewBooks.ImageOffset = new System.Drawing.Point(0, 4);
            this.btnViewBooks.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewBooks.Location = new System.Drawing.Point(548, 12);
            this.btnViewBooks.Name = "btnViewBooks";
            this.btnViewBooks.Size = new System.Drawing.Size(166, 75);
            this.btnViewBooks.TabIndex = 5;
            this.btnViewBooks.Text = "View Books";
            this.btnViewBooks.TextOffset = new System.Drawing.Point(3, 0);
            this.btnViewBooks.Click += new System.EventHandler(this.btnViewBooks_Click);
            // 
            // btnCompleteBooksDetails
            // 
            this.btnCompleteBooksDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnCompleteBooksDetails.BorderRadius = 26;
            this.btnCompleteBooksDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCompleteBooksDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCompleteBooksDetails.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCompleteBooksDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleteBooksDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleteBooksDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompleteBooksDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompleteBooksDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnCompleteBooksDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteBooksDetails.ForeColor = System.Drawing.Color.White;
            this.btnCompleteBooksDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnCompleteBooksDetails.Image")));
            this.btnCompleteBooksDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCompleteBooksDetails.ImageOffset = new System.Drawing.Point(-7, 0);
            this.btnCompleteBooksDetails.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCompleteBooksDetails.Location = new System.Drawing.Point(1102, 11);
            this.btnCompleteBooksDetails.Name = "btnCompleteBooksDetails";
            this.btnCompleteBooksDetails.Size = new System.Drawing.Size(178, 75);
            this.btnCompleteBooksDetails.TabIndex = 4;
            this.btnCompleteBooksDetails.Text = "All Books Deatails";
            this.btnCompleteBooksDetails.TextOffset = new System.Drawing.Point(17, 0);
            this.btnCompleteBooksDetails.Click += new System.EventHandler(this.btnCompleteBooksDetails_Click);
            // 
            // btnReturnBooks
            // 
            this.btnReturnBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnReturnBooks.BorderRadius = 26;
            this.btnReturnBooks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReturnBooks.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnReturnBooks.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnReturnBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturnBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturnBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturnBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturnBooks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnReturnBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBooks.ForeColor = System.Drawing.Color.White;
            this.btnReturnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnBooks.Image")));
            this.btnReturnBooks.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReturnBooks.Location = new System.Drawing.Point(921, 11);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(156, 75);
            this.btnReturnBooks.TabIndex = 3;
            this.btnReturnBooks.Text = "Return Books";
            this.btnReturnBooks.TextOffset = new System.Drawing.Point(3, 0);
            this.btnReturnBooks.Click += new System.EventHandler(this.btnReturnBooks_Click);
            // 
            // btnIssuedBooks
            // 
            this.btnIssuedBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnIssuedBooks.BorderRadius = 26;
            this.btnIssuedBooks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnIssuedBooks.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnIssuedBooks.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnIssuedBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssuedBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssuedBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssuedBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIssuedBooks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnIssuedBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssuedBooks.ForeColor = System.Drawing.Color.White;
            this.btnIssuedBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnIssuedBooks.Image")));
            this.btnIssuedBooks.ImageSize = new System.Drawing.Size(25, 25);
            this.btnIssuedBooks.Location = new System.Drawing.Point(736, 12);
            this.btnIssuedBooks.Name = "btnIssuedBooks";
            this.btnIssuedBooks.Size = new System.Drawing.Size(163, 75);
            this.btnIssuedBooks.TabIndex = 2;
            this.btnIssuedBooks.Text = "Issued Books";
            this.btnIssuedBooks.TextOffset = new System.Drawing.Point(3, 0);
            this.btnIssuedBooks.Click += new System.EventHandler(this.btnIssuedBooks_Click);
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnViewStudent.BorderRadius = 26;
            this.btnViewStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewStudent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewStudent.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnViewStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudent.ForeColor = System.Drawing.Color.White;
            this.btnViewStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnViewStudent.Image")));
            this.btnViewStudent.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnViewStudent.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewStudent.Location = new System.Drawing.Point(190, 12);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(152, 75);
            this.btnViewStudent.TabIndex = 1;
            this.btnViewStudent.Text = "View Student";
            this.btnViewStudent.Click += new System.EventHandler(this.btnViewStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStudent.BorderRadius = 26;
            this.btnAddStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddStudent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddStudent.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddStudent.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnAddStudent.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddStudent.Location = new System.Drawing.Point(7, 12);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(161, 75);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.TextOffset = new System.Drawing.Point(12, 0);
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(-256, 224);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(-256, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimized.BackgroundImage")));
            this.btnMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimized.Location = new System.Drawing.Point(5, 57);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 30);
            this.btnMinimized.TabIndex = 14;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(5, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExitt_Click);
            // 
            // uC_AddStudent1
            // 
            this.uC_AddStudent1.BackColor = System.Drawing.Color.White;
            this.uC_AddStudent1.Location = new System.Drawing.Point(29, 109);
            this.uC_AddStudent1.Name = "uC_AddStudent1";
            this.uC_AddStudent1.Size = new System.Drawing.Size(1305, 620);
            this.uC_AddStudent1.TabIndex = 15;
            // 
            // uC_ViewStudent1
            // 
            this.uC_ViewStudent1.BackColor = System.Drawing.Color.White;
            this.uC_ViewStudent1.Location = new System.Drawing.Point(29, 109);
            this.uC_ViewStudent1.Name = "uC_ViewStudent1";
            this.uC_ViewStudent1.Size = new System.Drawing.Size(1305, 620);
            this.uC_ViewStudent1.TabIndex = 16;
            // 
            // uC_AddBook1
            // 
            this.uC_AddBook1.BackColor = System.Drawing.Color.White;
            this.uC_AddBook1.Location = new System.Drawing.Point(29, 109);
            this.uC_AddBook1.Name = "uC_AddBook1";
            this.uC_AddBook1.Size = new System.Drawing.Size(1305, 620);
            this.uC_AddBook1.TabIndex = 17;
            // 
            // uC_ViewBooks1
            // 
            this.uC_ViewBooks1.BackColor = System.Drawing.Color.White;
            this.uC_ViewBooks1.Location = new System.Drawing.Point(29, 109);
            this.uC_ViewBooks1.Name = "uC_ViewBooks1";
            this.uC_ViewBooks1.Size = new System.Drawing.Size(1305, 620);
            this.uC_ViewBooks1.TabIndex = 18;
            // 
            // uC_IssueBooks1
            // 
            this.uC_IssueBooks1.BackColor = System.Drawing.Color.White;
            this.uC_IssueBooks1.Location = new System.Drawing.Point(29, 109);
            this.uC_IssueBooks1.Name = "uC_IssueBooks1";
            this.uC_IssueBooks1.Size = new System.Drawing.Size(1305, 620);
            this.uC_IssueBooks1.TabIndex = 19;
            // 
            // uC_ReturnBook1
            // 
            this.uC_ReturnBook1.BackColor = System.Drawing.Color.White;
            this.uC_ReturnBook1.Location = new System.Drawing.Point(29, 109);
            this.uC_ReturnBook1.Name = "uC_ReturnBook1";
            this.uC_ReturnBook1.Size = new System.Drawing.Size(1305, 620);
            this.uC_ReturnBook1.TabIndex = 20;
            // 
            // uC_CompleteBookDetails1
            // 
            this.uC_CompleteBookDetails1.BackColor = System.Drawing.Color.White;
            this.uC_CompleteBookDetails1.Location = new System.Drawing.Point(29, 109);
            this.uC_CompleteBookDetails1.Name = "uC_CompleteBookDetails1";
            this.uC_CompleteBookDetails1.Size = new System.Drawing.Size(1305, 620);
            this.uC_CompleteBookDetails1.TabIndex = 21;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1329, 676);
            this.Controls.Add(this.uC_CompleteBookDetails1);
            this.Controls.Add(this.uC_ReturnBook1);
            this.Controls.Add(this.uC_IssueBooks1);
            this.Controls.Add(this.uC_ViewBooks1);
            this.Controls.Add(this.uC_AddBook1);
            this.Controls.Add(this.uC_ViewStudent1);
            this.Controls.Add(this.uC_AddStudent1);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnCompleteBooksDetails;
        private Guna.UI2.WinForms.Guna2Button btnReturnBooks;
        private Guna.UI2.WinForms.Guna2Button btnIssuedBooks;
        private Guna.UI2.WinForms.Guna2Button btnViewStudent;
        private Guna.UI2.WinForms.Guna2Button btnAddStudent;
        private System.Windows.Forms.Button btnMinimized;
        private Guna.UI2.WinForms.Guna2Button btnAddBooks;
        private Guna.UI2.WinForms.Guna2Button btnViewBooks;
        private System.Windows.Forms.Button button1;
        private Library.UC_AddStudent uC_AddStudent1;
        private Library.UC_ViewStudent uC_ViewStudent1;
        private Library.UC_AddBook uC_AddBook1;
        private UC_ViewBooks uC_ViewBooks1;
        private Library.UC_IssueBooks uC_IssueBooks1;
        private Library.UC_ReturnBook uC_ReturnBook1;
        private Library.UC_CompleteBookDetails uC_CompleteBookDetails1;
    }
}