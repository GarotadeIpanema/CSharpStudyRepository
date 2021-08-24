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

namespace BookManagementProgram.RentalControls
{
    public partial class SelectRentalHistory : Form
    {
        BookRentalRepository rentalRepository = null;
        public SelectRentalHistory()
        {
            InitializeComponent();
            rentalRepository = new BookRentalRepository();

            InitGridControl();
            this.gridControl1.DataSource = rentalRepository.GetRentalHistory();
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
            saveFileDialog.FileName = "전체렌탈기록";
            saveFileDialog.Filter = "Excel |*.xlsx";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                gridControl1.ExportToXlsx(path);
                Process.Start(path);
            }
            
        }
    }
}
