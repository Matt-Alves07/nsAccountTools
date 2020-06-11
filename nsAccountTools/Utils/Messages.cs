using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nsAccountTools.Utils
{
    class Messages
    {
        public DialogResult SendQuestion(string _text, string _caption)
        {
            return MessageBox.Show(_text, _caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
        }
    }
}
