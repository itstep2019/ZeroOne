using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ZeroOne.Model
{
    class TxtDocument : Interfaces.IDocument
    {
       // XmlDocument document = new XmlDocument();

        public string Data { get; private set; }

        public void read()
        {
            //document.Load("file.txt");
        }


    }
}
