using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using SautinSoft.Document;

namespace ZeroOne.Documents
{
    class TxtDocument : Interfaces.IDocument
    {
        public TxtDocument(DocumentCore doc) => Document = doc;

        public DocumentCore Document { get; private set; }
    }
}
