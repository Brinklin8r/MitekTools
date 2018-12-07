using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowsFormUI {
    public partial class MitekToolsForm : Form {
        public MitekToolsForm() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void btnMin_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e) {
            pnlSelect.Height = btnHome.Height;
            pnlSelect.Top = btnHome.Top;
        }

        private void btnImageSearch_Click(object sender, EventArgs e) {
            pnlSelect.Height = btnImageSearch.Height;
            pnlSelect.Top = btnImageSearch.Top;
        }

        private void btnRestEndor_Click(object sender, EventArgs e) {
            pnlSelect.Height = btnRestEndor.Height;
            pnlSelect.Top = btnRestEndor.Top;
        }


    }
}
