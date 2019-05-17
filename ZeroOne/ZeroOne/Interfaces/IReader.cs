using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroOne.Interfaces
{
    interface IReader
    {
        Task<IDocument> ReadAsync(string path);
        IDocument Read(string path);
    }
}
