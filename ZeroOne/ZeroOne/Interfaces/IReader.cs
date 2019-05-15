using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroOne.Interfaces
{
    interface IReader
    {
        Task<Interfaces.IDocument> Read(string path);
    }
}
