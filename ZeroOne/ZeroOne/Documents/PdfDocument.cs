using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SautinSoft.Document;

namespace ZeroOne.Documents
{
    class PdfDocument : Interfaces.IDocument
    {
        public PdfDocument(DocumentCore doc)
        {
            Document = doc;
        }

        public DocumentCore Document { get; private set; }        
    }
}
