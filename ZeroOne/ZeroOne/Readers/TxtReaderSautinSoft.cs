using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SautinSoft.Document;
using ZeroOne.Interfaces;



namespace ZeroOne.Readers
{
    class TxtReaderSautinSoft : Interfaces.IReader
    {
        public Task<IDocument> Read(string path)
        {
            //return Task.Run(async () => { });

            //DocumentCore txt = DocumentCore.Load(path, new TxtLoadOptions());
            return null;
            //return new Documents.TxtDocument("");
        }
    }
}
