using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZeroOne.Helpers
{
    class Dialogs
    {
        public static string[] OpenFileDialog(System.Windows.Forms.IWin32Window owner = null)
        {
            string[] files = Array.Empty<string>();

            using (var open = new System.Windows.Forms.OpenFileDialog())
            {
                open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                open.Filter = "Текстовые документы (*.txt)|*.txt|" +
                    "Portable Document Format (*.pdf)|*.pdf|" +
                    "Rich Text Format (*.rtf)|*.rtf";


                //"Текстовые документы (*.txt)| .txt | " +
                //"Portable Document Format (*.pdf) | .pdf | " +
                //"Rich Text Format (*.rtf) | .rtf";

                //Текстовые файлы(*.txt)| *.txt | Все файлы(*.*) | *.*

                open.Multiselect = true;
                open.CheckPathExists = true;
                open.CheckFileExists = true;

                if (open.ShowDialog(owner) == System.Windows.Forms.DialogResult.OK)
                    files = open.FileNames;
            }

            return files;
        }



    }
}
