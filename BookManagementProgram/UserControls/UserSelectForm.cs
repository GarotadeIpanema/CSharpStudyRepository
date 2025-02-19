﻿using BookManagementProgram.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using System.Windows.Forms;

namespace BookManagementProgram.UserControls
{
    public partial class UserSelectForm : Form
    {
        BookUserRepository userRepository = null;

        public UserSelectForm()
        {
            InitializeComponent();
            userRepository = new BookUserRepository();

            InitGridControl();
            this.gridControl1.DataSource = userRepository.GetAllUsers();
        }

        private void InitGridControl()
        {
            GridView gv = this.gridControl1.MainView as GridView;
            gv.OptionsView.ShowGroupPanel = false;
            gv.OptionsBehavior.Editable = false;
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "사용자기록";
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
