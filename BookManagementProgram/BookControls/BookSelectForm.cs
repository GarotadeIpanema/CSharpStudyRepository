using BookManagementProgram.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementProgram.BookControls
{
    public partial class BookSelectForm : Form
    {
        BookRepository bookRepository = null;
        public BookSelectForm()
        {
            InitializeComponent();

            bookRepository = new BookRepository();

            InitGridControl();
            this.gridControl1.DataSource = bookRepository.GetAllBooks();
        }

        private void InitGridControl()
        {
            GridView gv = this.gridControl1.MainView as GridView;
            gv.OptionsView.ShowGroupPanel = false;
            gv.OptionsBehavior.Editable = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "도서기록";
            saveFileDialog.Filter = "Excel |*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                gridControl1.ExportToXlsx(path);
                Process.Start(path);
            }
        }
    }
}
