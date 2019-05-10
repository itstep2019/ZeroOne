using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroOne.Interfaces;

namespace ZeroOne.Model
{
    class TxtReader : IReader
    {
        public IDocument Read(string path)
        {


            return new TxtDocument();
        }
    }
}
