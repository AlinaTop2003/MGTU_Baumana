using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MGTU_Baumana.ModelEF;
using MGTU_Baumana.Forms;

namespace MGTU_Baumana
{
    public partial class MainForm : Form
    {
        Model1 model1 = new Model1();
        User user;
        public MainForm(User user)
        {
            InitializeComponent();
            pnlNav.Height = btnContract.Height;
            pnlNav.Top = btnContract.Top;
            pnlNav.Left = btnContract.Left;

            this.user = user;
            UserName.Text = $"{user.LustName} {user.FirsName}";
            UserRole.Text = user.Role.Title;
        }


        private void btnContract_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContract.Height;
            pnlNav.Top = btnContract.Top;
            pnlNav.Left = btnContract.Left;
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReceipt.Height;
            pnlNav.Top = btnReceipt.Top;
        }

        private void btnPayReport_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPayReport.Height;
            pnlNav.Top = btnPayReport.Top;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnStudent.Height;
            pnlNav.Top = btnStudent.Top;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
