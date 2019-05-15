using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using ZeroOne.Documents;
using ZeroOne.Interfaces;

namespace ZeroOne.Readers
{
    class TxtReader : IReader
    {
        public async Task<IDocument> Read(string path)
        {
            string buf = string.Empty;

            using (var fStream = new StreamReader(path, Encoding.Default))
                buf = await fStream.ReadToEndAsync();
                

            return new TxtDocument(buf);
        }
    }
}
