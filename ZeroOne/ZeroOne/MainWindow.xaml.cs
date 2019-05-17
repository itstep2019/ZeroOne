using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZeroOne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ReadAsync("text.txt");
            Read("text.txt");
        }

        public async void ReadAsync(string path)
        {
            Interfaces.IReader reader = new Readers.TxtReader();
            Interfaces.IDocument doc = await reader.ReadAsync(path);
        }

        public void Read(string path)
        {
            Interfaces.IReader reader = new Readers.TxtReader();
            Interfaces.IDocument doc = reader.Read(path);
        }
    }
}
