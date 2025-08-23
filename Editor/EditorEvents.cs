using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCAD
{
    public delegate void EditorPromptEventHandler(object sender, EditorPromptEventArgs e);

    public class EditorPromptEventArgs : EventArgs
    {
        public string Status { get; private set; }

        public EditorPromptEventArgs() : this("")
        {
            ;
        }

        public EditorPromptEventArgs(string status) : base()
        {
            Status = status;
        }
    }
}
