using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using ZeroOne.Code;

namespace ZeroOne.ViewModel
{

    public class View_Model_Main : View_Model_Base
    {

        private readonly Model.Saver saver = new Model.Saver();

        public View_Model_Main()
        {
            TabItem.ViewModel = this;

            CreateNewFileCommand.Execute(null);
        }


        #region variable

        public ObservableCollection<TabItem> Tabs { get; private set; } = new ObservableCollection<TabItem>();


        private TabItem _selectedTab = null;
        public TabItem SelectedTab
        {
            get => _selectedTab;
            set => SetProperty(ref _selectedTab, value, nameof(SelectedTab));
        }


        #endregion variable


        #region Functions

        #endregion Functions


        #region Commands

        
       
        public void CloseTabCommandExecute(object obj)
        {
            int id = (int)obj;

            var sel = Tabs.Where(t => t.Id == id).First();

            if (!sel.IsSaved)
            {
                if (MessageBox.Show("Сохранить этот файл?", "Закрытие вкладки", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SaveCommand.Execute(null);
                }
            }

            Tabs.Remove(sel);

            if (Tabs.Count == 0)
            {
                Tabs.Add(new TabItem() { Header = "Новый документ" });
                SelectedTab = Tabs.First();
            }
        }
        public bool CloseTabCommandCanExecute(object obj)
        {
            return true;
        }

        #region Menu

        #region File

        #region Button_click_new_file

        private DelegateCommand _Command_new_file;
        public ICommand CreateNewFileCommand
        {
            get
            {
                if (_Command_new_file == null)
                {
                    _Command_new_file = new DelegateCommand(Execute_new_file, CanExecute_new_file);
                }
                return _Command_new_file;
            }
        }
        private void Execute_new_file(object o)
        {
            Tabs.Add(new TabItem() { Header = "Новый документ", IsCreated = true });
            SelectedTab = Tabs.Last();

        }
        private bool CanExecute_new_file(object o)
        {
         
            return true;
        }

        #endregion  Button_click_new_file

        #region Button_click_open_file

        private DelegateCommand _Command_open_file;
        public ICommand OpenFileCommand
        {
            get
            {
                if (_Command_open_file == null)
                {
                    _Command_open_file = new DelegateCommand(Execute_open_file, CanExecute_open_file);
                }
                return _Command_open_file;
            }
        }
        private async void Execute_open_file(object o)
        {
            var files = Helpers.Dialogs.OpenFileDialog();

            if  (files.Length > 0)
            {
                Interfaces.IReader reader = new Readers.TxtReader();
                foreach (var file in files)
                {
                    Interfaces.IDocument doc = await reader.ReadAsync(file);

                    Tabs.Add(new TabItem() {
                        Header = Path.GetFileName(file),
                        Path = file,
                        Content = doc.Document.Content.ToString(),
                        IsCreated = false
                    });

                    SelectedTab = Tabs.Last();
                }
            }
            

            
        }
        private bool CanExecute_open_file(object o)
        {
            return true;
        }

        #endregion  Button_click_open_file

        #region Button_click_file_save

        private DelegateCommand _Command_file_save;
        public ICommand SaveCommand
        {
            get
            {
                if (_Command_file_save == null)
                {
                    _Command_file_save = new DelegateCommand(Execute_file_save, CanExecute_file_save);
                }
                return _Command_file_save;
            }
        }
        private async void Execute_file_save(object o)
        {
            if (SelectedTab == null)
                return;

            var tab = SelectedTab;
            
            if (tab.Path == string.Empty)
            {
                var path = Helpers.Dialogs.SaveFileDialog(tab.Header);
                if (path != "")
                    tab.Path = path;
                else
                    return;
            }

            await saver.Save(tab);
            tab.IsSaved = true;
        }
        private bool CanExecute_file_save(object o)
        {
            return true;
        }

        #endregion  Button_click_file_save

        #region Button_click_file_save_as

        private DelegateCommand _Command_file_save_as;
        public ICommand Button_click_file_save_as
        {
            get
            {
                if (_Command_file_save_as == null)
                {
                    _Command_file_save_as = new DelegateCommand(Execute_file_save_as, CanExecute_file_save_as);
                }
                return _Command_file_save_as;
            }
        }
        private void Execute_file_save_as(object o)
        {


        }
        private bool CanExecute_file_save_as(object o)
        {

            return true;
        }

        #endregion  Button_click_file_save_as

        #region Button_click_file_save_all

        private DelegateCommand _Command_file_save_all;
        public ICommand Button_click_file_save_all
        {
            get
            {
                if (_Command_file_save_all == null)
                {
                    _Command_file_save_all = new DelegateCommand(Execute_file_save_all, CanExecute_file_save_all);
                }
                return _Command_file_save_all;
            }
        }
        private void Execute_file_save_all(object o)
        {


        }
        private bool CanExecute_file_save_all(object o)
        {

            return true;
        }

        #endregion  Button_click_file_save_all


        #endregion File

        #endregion Menu

        #endregion Comands
    }
}
