using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nsAccountTools.Utils;

namespace nsAccountTools
{
    public partial class frmInicial : Form
    {
        Messages messages = new Messages();
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (messages.SendQuestion("Deseja realmente sair?", "Sair") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
