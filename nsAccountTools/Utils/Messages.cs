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
        public static DialogResult SendQuestion(string _text, string _caption) => MessageBox.Show(_text, _caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        public static DialogResult SendQuestionWithCancel(string _text, string _caption) => MessageBox.Show(_text, _caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

        public static void SendError(string _text, string _caption) => MessageBox.Show(_text, _caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void SendWarning(string _text, string _caption) => MessageBox.Show(_text, _caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        public static void SendInfo(string _text, string _caption) => MessageBox.Show(_text, _caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
