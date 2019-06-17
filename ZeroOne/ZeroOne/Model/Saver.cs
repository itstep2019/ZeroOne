using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ZeroOne.ViewModel;

namespace ZeroOne.Model
{
    public class Saver
    {
        public async Task Save(string path, string content)
        {
            TextWriter wr = new StreamWriter(path, false, Encoding.Default);
            await Save(wr, content);
        }

        public async Task Save(TabItem item)
        {            
            await Save(item.Path, item.Content);
        }

        private async Task Save(TextWriter stream, string content)
        {
            await stream.WriteAsync(content);
            await stream.FlushAsync();
            stream.Close();
        }

    }
}
