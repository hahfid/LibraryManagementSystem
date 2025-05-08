using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.returnBooks_btn = new System.Windows.Forms.Button();
            this.issueBooks_btn = new System.Windows.Forms.Button();
            this.addBooks_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greet_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard1 = new LibraryManagementSystem.Dashboard();
            this.addBooks1 = new LibraryManagementSystem.AddBooks();
            this.issueBooks1 = new LibraryManagementSystem.IssueBooks();
            this.returnBooks1 = new LibraryManagementSystem.ReturnBooks();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(134)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1650, 53);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Management System | Main Form";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1623, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(134)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.returnBooks_btn);
            this.panel2.Controls.Add(this.issueBooks_btn);
            this.panel2.Controls.Add(this.addBooks_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greet_label);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 817);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 817);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Log out";
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_20px;
            this.logout_btn.Location = new System.Drawing.Point(12, 803);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(52, 54);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // returnBooks_btn
            // 
            this.returnBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBooks_btn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_return_32px_3;
            this.returnBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBooks_btn.Location = new System.Drawing.Point(12, 520);
            this.returnBooks_btn.Name = "returnBooks_btn";
            this.returnBooks_btn.Size = new System.Drawing.Size(300, 69);
            this.returnBooks_btn.TabIndex = 5;
            this.returnBooks_btn.Text = "RETURN BOOKS";
            this.returnBooks_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnBooks_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.returnBooks_btn.UseVisualStyleBackColor = true;
            this.returnBooks_btn.Click += new System.EventHandler(this.returnBooks_btn_Click);
            // 
            // issueBooks_btn
            // 
            this.issueBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBooks_btn.ForeColor = System.Drawing.Color.White;
            this.issueBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px_1;
            this.issueBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBooks_btn.Location = new System.Drawing.Point(12, 442);
            this.issueBooks_btn.Name = "issueBooks_btn";
            this.issueBooks_btn.Size = new System.Drawing.Size(300, 69);
            this.issueBooks_btn.TabIndex = 4;
            this.issueBooks_btn.Text = "ISSUE BOOKS";
            this.issueBooks_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.issueBooks_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.issueBooks_btn.UseVisualStyleBackColor = true;
            this.issueBooks_btn.Click += new System.EventHandler(this.issueBooks_btn_Click);
            // 
            // addBooks_btn
            // 
            this.addBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_btn.ForeColor = System.Drawing.Color.White;
            this.addBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px;
            this.addBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBooks_btn.Location = new System.Drawing.Point(12, 363);
            this.addBooks_btn.Name = "addBooks_btn";
            this.addBooks_btn.Size = new System.Drawing.Size(300, 69);
            this.addBooks_btn.TabIndex = 3;
            this.addBooks_btn.Text = "ADD BOOKS";
            this.addBooks_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBooks_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBooks_btn.UseVisualStyleBackColor = true;
            this.addBooks_btn.Click += new System.EventHandler(this.addBooks_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_dashboard_32px;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 285);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(300, 69);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // greet_label
            // 
            this.greet_label.AutoSize = true;
            this.greet_label.Font = new System.Drawing.Font("Tahoma", 12F);
            this.greet_label.ForeColor = System.Drawing.Color.White;
            this.greet_label.Location = new System.Drawing.Point(62, 202);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(190, 29);
            this.greet_label.TabIndex = 1;
            this.greet_label.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.icons8_library_100px;
            this.pictureBox1.Location = new System.Drawing.Point(87, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addBooks1);
            this.panel3.Controls.Add(this.issueBooks1);
            this.panel3.Controls.Add(this.returnBooks1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(329, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1321, 817);
            this.panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1321, 817);
            this.dashboard1.TabIndex = 0;
            // 
            // addBooks1
            // 
            this.addBooks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBooks1.Location = new System.Drawing.Point(0, 0);
            this.addBooks1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(1321, 817);
            this.addBooks1.TabIndex = 1;
            // 
            // issueBooks1
            // 
            this.issueBooks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueBooks1.Location = new System.Drawing.Point(0, 0);
            this.issueBooks1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(1321, 817);
            this.issueBooks1.TabIndex = 2;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnBooks1.Location = new System.Drawing.Point(0, 0);
            this.returnBooks1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(1321, 817);
            this.returnBooks1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1650, 870);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Button logout_btn;
        private Button returnBooks_btn;
        private Button issueBooks_btn;
        private Button addBooks_btn;
        private Button dashboard_btn;
        private Label greet_label;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Dashboard dashboard1;
        private AddBooks addBooks1;
        private IssueBooks issueBooks1;
        private ReturnBooks returnBooks1;
    }
}