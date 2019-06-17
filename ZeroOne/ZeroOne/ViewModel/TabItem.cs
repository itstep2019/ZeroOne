using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroOne.ViewModel
{
    public sealed class TabItem
    {
        private static int counter = 0;

        public static View_Model_Main ViewModel { get; set; }

        public TabItem()
        {
            CloseTabCommand = new Code.DelegateCommand(ViewModel.CloseTabCommandExecute, ViewModel.CloseTabCommandCanExecute);
            CloseAllTabsCommand = ViewModel.CloseAllTabsCommand;
            CloseAllTabsUnlessCurrent = ViewModel.CloseAllTabsUnlessCurrent;

            ++counter;
            Id = counter;
        }

        public int Id { get; private set; }

        public bool IsCreated { get; set; }
        public string Path { get; set; } = string.Empty;
        public string Header { get; set; }

        private string _content = string.Empty;
        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                if (_content != string.Empty)
                    IsSaved = false;
            }
        }
        public bool IsSaved { get; set; }
        

        public System.Windows.Input.ICommand CloseTabCommand { get; private set; }

        public System.Windows.Input.ICommand CloseAllTabsCommand { get; private set; }
        public System.Windows.Input.ICommand CloseAllTabsUnlessCurrent { get; private set; }
    }
}
