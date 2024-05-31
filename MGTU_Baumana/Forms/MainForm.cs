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

namespace MGTU_Baumana
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            pnlNav.Height = btnContract.Height;
            pnlNav.Top = btnContract.Top;
            pnlNav.Left = btnContract.Left;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
