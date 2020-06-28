using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nsAccountTools.Views
{
    public partial class frmOpcoesFolha : Form
    {
        string connString = "";
        public frmOpcoesFolha(string _connString)
        {
            InitializeComponent();
            connString = _connString;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
