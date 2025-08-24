using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace BaseCAD
{
    internal class OpenFilenameGetter : EditorGetter<FilenameOptions, string>
    {
        protected override void Init(InitArgs<string> args)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = Options.Message;
            ofd.Filter = Options.Filter;
            ofd.DefaultExt = "scf";
            string filename = "";
            string path = "";
            try
            {
                filename = Path.GetFileName(Options.FileName);
                path = Path.GetDirectoryName(Options.FileName);
            }
            catch
            {
                ;
            }
            if (!string.IsNullOrEmpty(filename)) ofd.FileName = filename;
            if (!string.IsNullOrEmpty(path)) ofd.InitialDirectory = path;

            if (ofd.ShowDialog() == DialogResult.OK)
                args.Value = ofd.FileName;
            else
                args.InputValid = false;

            args.ContinueAsync = false;
        }
    }
}
