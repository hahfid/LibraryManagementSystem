using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagementSystem.Models;
using System.IO;

namespace LibraryManagementSystem
{
    public partial class IssueBooks : UserControl
    {
        private readonly IssueBooksModel model = new IssueBooksModel();

        public IssueBooks()
        {
            InitializeComponent();
            displayBookIssueData();
            DataBookTitle();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayBookIssueData();
            DataBookTitle();
        }

        public void displayBookIssueData()
        {
            dataGridView1.DataSource = model.GetAllIssues();
        }

        public void DataBookTitle()
        {
            try
            {
                bookIssue_bookTitle.DataSource = model.GetAvailableBooks();
                bookIssue_bookTitle.DisplayMember = "book_title";
                bookIssue_bookTitle.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bookIssue_bookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookIssue_bookTitle.SelectedValue != null && bookIssue_bookTitle.SelectedItem is DataRowView selectedRow)
            {
                int selectID = Convert.ToInt32(selectedRow["id"]);
                try
                {
                    bookIssue_picture.Image = model.GetBookImageById(selectID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bookIssue_addBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            try
            {
                model.InsertIssue(
                    bookIssue_id.Text.Trim(),
                    bookIssue_name.Text.Trim(),
                    bookIssue_contact.Text.Trim(),
                    bookIssue_email.Text.Trim(),
                    bookIssue_bookTitle.Text.Trim(),
                    bookIssue_status.Text.Trim(),
                    bookIssue_issueDate.Value,
                    bookIssue_returnDate.Value
                );

                displayBookIssueData();
                MessageBox.Show("Issued successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bookIssue_updateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            DialogResult confirm = MessageBox.Show("Are you sure you want to UPDATE Issue ID: " + bookIssue_id.Text.Trim() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            try
            {
                model.UpdateIssue(
                    bookIssue_id.Text.Trim(),
                    bookIssue_name.Text.Trim(),
                    bookIssue_contact.Text.Trim(),
                    bookIssue_email.Text.Trim(),
                    bookIssue_bookTitle.Text.Trim(),
                    bookIssue_status.Text.Trim(),
                    bookIssue_issueDate.Value,
                    bookIssue_returnDate.Value
                );

                displayBookIssueData();
                MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bookIssue_deleteBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            DialogResult confirm = MessageBox.Show("Are you sure you want to DELETE Issue ID: " + bookIssue_id.Text.Trim() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            try
            {
                model.DeleteIssue(bookIssue_id.Text.Trim());
                displayBookIssueData();
                MessageBox.Show("Deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bookIssue_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            bookIssue_id.Text = "";
            bookIssue_name.Text = "";
            bookIssue_contact.Text = "";
            bookIssue_email.Text = "";
            bookIssue_bookTitle.SelectedIndex = -1;
            bookIssue_status.SelectedIndex = -1;
            bookIssue_picture.Image = null;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bookIssue_id.Text = row.Cells[1].Value?.ToString();
                bookIssue_name.Text = row.Cells[2].Value?.ToString();
                bookIssue_contact.Text = row.Cells[3].Value?.ToString();
                bookIssue_email.Text = row.Cells[4].Value?.ToString();
                bookIssue_bookTitle.Text = row.Cells[5].Value?.ToString();
                bookIssue_status.Text = row.Cells[9].Value?.ToString();

                if (DateTime.TryParse(row.Cells[7].Value?.ToString(), out DateTime issueDate))
                    bookIssue_issueDate.Value = issueDate;

                if (DateTime.TryParse(row.Cells[8].Value?.ToString(), out DateTime returnDate))
                    bookIssue_returnDate.Value = returnDate;
            }
        }

        private bool ValidateFields()
        {
            return !(string.IsNullOrWhiteSpace(bookIssue_id.Text) ||
                     string.IsNullOrWhiteSpace(bookIssue_name.Text) ||
                     string.IsNullOrWhiteSpace(bookIssue_contact.Text) ||
                     string.IsNullOrWhiteSpace(bookIssue_email.Text) ||
                     string.IsNullOrWhiteSpace(bookIssue_bookTitle.Text) ||
                     string.IsNullOrWhiteSpace(bookIssue_status.Text) ||
                     bookIssue_picture.Image == null);
        }
    }
}
