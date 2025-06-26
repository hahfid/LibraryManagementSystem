using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ReturnBooks : UserControl
    {
        public ReturnBooks()
        {
            InitializeComponent();
            displayIssuedBooksData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayIssuedBooksData();
        }

        private void returnBooks_returnBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(returnBooks_issueID.Text) ||
                string.IsNullOrWhiteSpace(returnBooks_name.Text) ||
                string.IsNullOrWhiteSpace(returnBooks_contact.Text) ||
                string.IsNullOrWhiteSpace(returnBooks_email.Text) ||
                string.IsNullOrWhiteSpace(returnBooks_bookTitle.Text) ||
                string.IsNullOrWhiteSpace(returnBooks_author.Text))
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure that Issue ID: "
                    + returnBooks_issueID.Text.Trim()
                    + " is returned already?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    ReturnBookQuery query = new ReturnBookQuery();
                    bool success = query.ReturnBook(returnBooks_issueID.Text.Trim());

                    if (success)
                    {
                        displayIssuedBooksData();
                        MessageBox.Show("Returned successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
                }
            }
        }

        public void displayIssuedBooksData()
        {
            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.ReturnIssueBooksData();
            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                returnBooks_issueID.Text = row.Cells[1].Value?.ToString();
                returnBooks_name.Text = row.Cells[2].Value?.ToString();
                returnBooks_contact.Text = row.Cells[3].Value?.ToString();
                returnBooks_email.Text = row.Cells[4].Value?.ToString();
                returnBooks_bookTitle.Text = row.Cells[5].Value?.ToString();
                returnBooks_author.Text = row.Cells[6].Value?.ToString();
                bookIssue_issueDate.Text = row.Cells[7].Value?.ToString();
            }
        }

        public void clearFields()
        {
            returnBooks_issueID.Text = "";
            returnBooks_name.Text = "";
            returnBooks_contact.Text = "";
            returnBooks_email.Text = "";
            returnBooks_bookTitle.Text = "";
            returnBooks_author.Text = "";
        }

        private void returnBooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
