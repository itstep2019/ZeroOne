using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SautinSoft.Document;
using ZeroOne.Interfaces;

namespace ZeroOne.Readers
{
    class PdfReader : IReader
    {
        public IDocument Read(string path)
        {
            if (System.IO.Path.GetExtension(path).ToLower() != ".pdf")
                throw new ArgumentException("TxtReader читает лишь файлы .pdf");

            DocumentCore doc = DocumentCore.Load(path);
            return new Documents.PdfDocument(doc);
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
