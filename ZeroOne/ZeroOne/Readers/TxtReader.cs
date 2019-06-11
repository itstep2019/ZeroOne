using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SautinSoft.Document;
using ZeroOne.Interfaces;



namespace ZeroOne.Readers
{
    class TxtReader : IReader
    {
        public IDocument Read(string path)
        {
            if (System.IO.Path.GetExtension(path).ToLower() != ".txt")
                throw new ArgumentException(nameof(PdfReader) + " читает лишь файлы .txt");

            DocumentCore txt = DocumentCore.Load(path);
            return new Documents.TxtDocument(txt);
        }

        public async Task<IDocument> ReadAsync(string path)
        {
            return await Task.Run(() => 
            {               
                return Read(path);
            });
        }
    }
}
