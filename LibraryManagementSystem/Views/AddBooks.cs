using LibraryManagementSystem.Models;
using LibraryManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddBooks : UserControl
    {
        private readonly BookController bookController = new BookController();
        private string imagePath;
        private int bookID = 0;

        public AddBooks()
        {
            InitializeComponent();
            displayBooks();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayBooks();
        }

        private void addBooks_importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = dialog.FileName;
                addBooks_picture.ImageLocation = imagePath;
            }
        }

        private void addBooks_addBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            try
            {
                BookModel book = new BookModel
                {
                    BookTitle = addBooks_bookTitle.Text.Trim(),
                    Author = addBooks_author.Text.Trim(),
                    PublishedDate = addBooks_published.Value,
                    Status = addBooks_status.Text.Trim()
                };

                bookController.AddBook(book, imagePath);
                displayBooks();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBooks_updateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            DialogResult confirm = MessageBox.Show("Update Book ID: " + bookID + "?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;

            try
            {
                BookModel book = new BookModel
                {
                    Id = bookID,
                    BookTitle = addBooks_bookTitle.Text.Trim(),
                    Author = addBooks_author.Text.Trim(),
                    PublishedDate = addBooks_published.Value,
                    Status = addBooks_status.Text.Trim()
                };

                bookController.UpdateBook(book);
                displayBooks();
                MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBooks_deleteBtn_Click(object sender, EventArgs e)
        {
            if (bookID == 0)
            {
                MessageBox.Show("Please select item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show("Delete Book ID: " + bookID + "?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;

            try
            {
                bookController.DeleteBook(bookID);
                displayBooks();
                MessageBox.Show("Deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayBooks()
        {
            List<BookModel> books = bookController.GetAllBooks();
            dataGridView1.DataSource = books;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            bookID = (int)row.Cells[0].Value;
            addBooks_bookTitle.Text = row.Cells[1].Value.ToString();
            addBooks_author.Text = row.Cells[2].Value.ToString();
            addBooks_published.Text = row.Cells[3].Value.ToString();
            addBooks_status.Text = row.Cells[4].Value.ToString();

            string imgPath = row.Cells[5].Value.ToString();
            if (File.Exists(imgPath))
            {
                addBooks_picture.Image = Image.FromFile(imgPath);
                imagePath = imgPath;
            }
            else
            {
                addBooks_picture.Image = null;
                imagePath = null;
            }
        }

        private void addBooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            addBooks_bookTitle.Text = "";
            addBooks_author.Text = "";
            addBooks_published.Value = DateTime.Today;
            addBooks_status.SelectedIndex = -1;
            addBooks_picture.Image = null;
            imagePath = null;
            bookID = 0;
        }

        private bool ValidateFields()
        {
            if (addBooks_picture.Image == null ||
                string.IsNullOrWhiteSpace(addBooks_bookTitle.Text) ||
                string.IsNullOrWhiteSpace(addBooks_author.Text) ||
                string.IsNullOrWhiteSpace(addBooks_status.Text))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Kosongkan jika tidak digunakan
        }
    }
}
