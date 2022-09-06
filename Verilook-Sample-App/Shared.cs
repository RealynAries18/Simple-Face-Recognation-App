using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verilook_Sample_App.Shared
{
    public static class Prompts
    {
        public static void ShowError(string message, string title) =>
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

    }
}
