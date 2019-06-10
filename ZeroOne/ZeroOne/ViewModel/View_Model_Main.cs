using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Time.View_model;
using ZeroOne.Code;

namespace ZeroOne.ViewModel
{

    public sealed class TabItem
    {
        private static int counter = 0;

        public TabItem()
        {
            ++counter;
            Id = counter;
        }

        public int Id { get; private set; }
        public string Header { get; set; }
        public string Content { get; set; }
    }

    class View_Model_Main : View_Model_Base
    {
        public View_Model_Main()
        {
            CloseTabCommand = new DelegateCommand(CloseTabCommandExecute, CloseTabCommandCanExecute);

            Tabs.Add(new TabItem { Header = "One", Content = "One's content" });
            Tabs.Add(new TabItem { Header = "Two", Content = "Two's content" });
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

        public ICommand CloseTabCommand { get; private set; }
       
        void CloseTabCommandExecute(object obj)
        {
            int id = (int)obj;

            var sel = Tabs.Select(t => t.Id == id).Single();

        }
        bool CloseTabCommandCanExecute(object obj)
        {
            return true;
        }

        #region Menu

        #region File

        #region Button_click_new_file

        private DelegateCommand _Command_new_file;
        public ICommand Button_click_new_file
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
            

        }
        private bool CanExecute_new_file(object o)
        {
         
            return false;
        }

        #endregion  Button_click_new_file

        #region Button_click_open_file

        private DelegateCommand _Command_open_file;
        public ICommand Button_click_open_file
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
        private void Execute_open_file(object o)
        {


        }
        private bool CanExecute_open_file(object o)
        {

            return false;
        }

        #endregion  Button_click_open_file

        #region Button_click_open_t_file

        private DelegateCommand _Command_open_t_file;
        public ICommand Button_click_open_t_file
        {
            get
            {
                if (_Command_open_t_file == null)
                {
                    _Command_open_t_file = new DelegateCommand(Execute_open_t_file, CanExecute_open_t_file);
                }
                return _Command_open_t_file;
            }
        }
        private void Execute_open_t_file(object o)
        {


        }
        private bool CanExecute_open_t_file(object o)
        {

            return false;
        }

        #endregion  Button_click_open_t_file

        #region Button_click_file_save

        private DelegateCommand _Command_file_save;
        public ICommand Button_click_file_save
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
        private void Execute_file_save(object o)
        {


        }
        private bool CanExecute_file_save(object o)
        {

            return false;
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

            return false;
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

            return false;
        }

        #endregion  Button_click_file_save_all


        #endregion File

        #endregion Menu

        #endregion Comands
    }
}
