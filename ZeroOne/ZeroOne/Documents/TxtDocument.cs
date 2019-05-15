using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ZeroOne.Documents
{
    class TxtDocument : Interfaces.IDocument
    {
       // XmlDocument document = new XmlDocument();

        public string Data { get; private set; }

        public TxtDocument(string data)
        {
            Data = data;
        }


    }
}
