using BookManagementProgram.Repository;
using DevExpress.XtraGrid.Views.Grid;
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
    }
}
