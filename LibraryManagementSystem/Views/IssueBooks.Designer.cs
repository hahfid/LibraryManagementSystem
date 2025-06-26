
namespace LibraryManagementSystem
{
    partial class IssueBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookIssue_status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bookIssue_clearBtn = new System.Windows.Forms.Button();
            this.bookIssue_deleteBtn = new System.Windows.Forms.Button();
            this.bookIssue_updateBtn = new System.Windows.Forms.Button();
            this.bookIssue_addBtn = new System.Windows.Forms.Button();
            this.bookIssue_returnDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.bookIssue_issueDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.bookIssue_picture = new System.Windows.Forms.PictureBox();
            this.bookIssue_bookTitle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bookIssue_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookIssue_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookIssue_contact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookIssue_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssue_picture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bookIssue_status);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.bookIssue_clearBtn);
            this.panel1.Controls.Add(this.bookIssue_deleteBtn);
            this.panel1.Controls.Add(this.bookIssue_updateBtn);
            this.panel1.Controls.Add(this.bookIssue_addBtn);
            this.panel1.Controls.Add(this.bookIssue_returnDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bookIssue_issueDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bookIssue_picture);
            this.panel1.Controls.Add(this.bookIssue_bookTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bookIssue_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bookIssue_email);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bookIssue_contact);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bookIssue_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(27, 526);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 316);
            this.panel1.TabIndex = 0;
            // 
            // bookIssue_status
            // 
            this.bookIssue_status.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_status.FormattingEnabled = true;
            this.bookIssue_status.Items.AddRange(new object[] {
            "Return",
            "Not Return"});
            this.bookIssue_status.Location = new System.Drawing.Point(850, 23);
            this.bookIssue_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_status.Name = "bookIssue_status";
            this.bookIssue_status.Size = new System.Drawing.Size(204, 32);
            this.bookIssue_status.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(768, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Status:";
            // 
            // bookIssue_clearBtn
            // 
            this.bookIssue_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.bookIssue_clearBtn.FlatAppearance.BorderSize = 0;
            this.bookIssue_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookIssue_clearBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_clearBtn.ForeColor = System.Drawing.Color.White;
            this.bookIssue_clearBtn.Location = new System.Drawing.Point(795, 243);
            this.bookIssue_clearBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_clearBtn.Name = "bookIssue_clearBtn";
            this.bookIssue_clearBtn.Size = new System.Drawing.Size(150, 51);
            this.bookIssue_clearBtn.TabIndex = 20;
            this.bookIssue_clearBtn.Text = "CLEAR";
            this.bookIssue_clearBtn.UseVisualStyleBackColor = false;
            this.bookIssue_clearBtn.Click += new System.EventHandler(this.bookIssue_clearBtn_Click);
            // 
            // bookIssue_deleteBtn
            // 
            this.bookIssue_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.bookIssue_deleteBtn.FlatAppearance.BorderSize = 0;
            this.bookIssue_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookIssue_deleteBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.bookIssue_deleteBtn.Location = new System.Drawing.Point(618, 243);
            this.bookIssue_deleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_deleteBtn.Name = "bookIssue_deleteBtn";
            this.bookIssue_deleteBtn.Size = new System.Drawing.Size(150, 51);
            this.bookIssue_deleteBtn.TabIndex = 19;
            this.bookIssue_deleteBtn.Text = "DELETE";
            this.bookIssue_deleteBtn.UseVisualStyleBackColor = false;
            this.bookIssue_deleteBtn.Click += new System.EventHandler(this.bookIssue_deleteBtn_Click);
            // 
            // bookIssue_updateBtn
            // 
            this.bookIssue_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.bookIssue_updateBtn.FlatAppearance.BorderSize = 0;
            this.bookIssue_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookIssue_updateBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_updateBtn.ForeColor = System.Drawing.Color.White;
            this.bookIssue_updateBtn.Location = new System.Drawing.Point(423, 243);
            this.bookIssue_updateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_updateBtn.Name = "bookIssue_updateBtn";
            this.bookIssue_updateBtn.Size = new System.Drawing.Size(150, 51);
            this.bookIssue_updateBtn.TabIndex = 18;
            this.bookIssue_updateBtn.Text = "UPDATE";
            this.bookIssue_updateBtn.UseVisualStyleBackColor = false;
            this.bookIssue_updateBtn.Click += new System.EventHandler(this.bookIssue_updateBtn_Click);
            // 
            // bookIssue_addBtn
            // 
            this.bookIssue_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.bookIssue_addBtn.FlatAppearance.BorderSize = 0;
            this.bookIssue_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookIssue_addBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_addBtn.ForeColor = System.Drawing.Color.White;
            this.bookIssue_addBtn.Location = new System.Drawing.Point(246, 243);
            this.bookIssue_addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_addBtn.Name = "bookIssue_addBtn";
            this.bookIssue_addBtn.Size = new System.Drawing.Size(150, 51);
            this.bookIssue_addBtn.TabIndex = 17;
            this.bookIssue_addBtn.Text = "ADD";
            this.bookIssue_addBtn.UseVisualStyleBackColor = false;
            this.bookIssue_addBtn.Click += new System.EventHandler(this.bookIssue_addBtn_Click);
            // 
            // bookIssue_returnDate
            // 
            this.bookIssue_returnDate.Location = new System.Drawing.Point(519, 178);
            this.bookIssue_returnDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_returnDate.Name = "bookIssue_returnDate";
            this.bookIssue_returnDate.Size = new System.Drawing.Size(289, 26);
            this.bookIssue_returnDate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 185);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Return:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookIssue_issueDate
            // 
            this.bookIssue_issueDate.Location = new System.Drawing.Point(519, 128);
            this.bookIssue_issueDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_issueDate.Name = "bookIssue_issueDate";
            this.bookIssue_issueDate.Size = new System.Drawing.Size(289, 26);
            this.bookIssue_issueDate.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Issue:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookIssue_picture
            // 
            this.bookIssue_picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bookIssue_picture.Location = new System.Drawing.Point(1086, 23);
            this.bookIssue_picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_picture.Name = "bookIssue_picture";
            this.bookIssue_picture.Size = new System.Drawing.Size(150, 154);
            this.bookIssue_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookIssue_picture.TabIndex = 12;
            this.bookIssue_picture.TabStop = false;
            // 
            // bookIssue_bookTitle
            // 
            this.bookIssue_bookTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_bookTitle.FormattingEnabled = true;
            this.bookIssue_bookTitle.Location = new System.Drawing.Point(519, 22);
            this.bookIssue_bookTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_bookTitle.Name = "bookIssue_bookTitle";
            this.bookIssue_bookTitle.Size = new System.Drawing.Size(204, 32);
            this.bookIssue_bookTitle.TabIndex = 9;
            this.bookIssue_bookTitle.SelectedIndexChanged += new System.EventHandler(this.bookIssue_bookTitle_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Book Title:";
            // 
            // bookIssue_id
            // 
            this.bookIssue_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_id.Location = new System.Drawing.Point(152, 23);
            this.bookIssue_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_id.Name = "bookIssue_id";
            this.bookIssue_id.Size = new System.Drawing.Size(216, 31);
            this.bookIssue_id.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Issue ID:";
            // 
            // bookIssue_email
            // 
            this.bookIssue_email.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_email.Location = new System.Drawing.Point(152, 180);
            this.bookIssue_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_email.Name = "bookIssue_email";
            this.bookIssue_email.Size = new System.Drawing.Size(216, 31);
            this.bookIssue_email.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // bookIssue_contact
            // 
            this.bookIssue_contact.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_contact.Location = new System.Drawing.Point(153, 128);
            this.bookIssue_contact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_contact.Name = "bookIssue_contact";
            this.bookIssue_contact.Size = new System.Drawing.Size(216, 31);
            this.bookIssue_contact.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact #:";
            // 
            // bookIssue_name
            // 
            this.bookIssue_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_name.Location = new System.Drawing.Point(152, 74);
            this.bookIssue_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookIssue_name.Name = "bookIssue_name";
            this.bookIssue_name.Size = new System.Drawing.Size(216, 31);
            this.bookIssue_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(27, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 482);
            this.panel2.TabIndex = 1;
            
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(32, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1204, 365);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Issued Books";
            // 
            // IssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IssueBooks";
            this.Size = new System.Drawing.Size(1320, 869);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssue_picture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookIssue_contact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookIssue_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookIssue_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookIssue_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox bookIssue_bookTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox bookIssue_picture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker bookIssue_returnDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker bookIssue_issueDate;
        private System.Windows.Forms.Button bookIssue_clearBtn;
        private System.Windows.Forms.Button bookIssue_deleteBtn;
        private System.Windows.Forms.Button bookIssue_updateBtn;
        private System.Windows.Forms.Button bookIssue_addBtn;
        private System.Windows.Forms.ComboBox bookIssue_status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
