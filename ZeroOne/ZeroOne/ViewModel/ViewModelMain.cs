using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Time.View_model;
using ZeroOne.Code;

namespace ZeroOne.ViewModel
{
    class View_Model_Main : View_Model_Base
    {
        #region variable



        #endregion variable


        #region Functions

        #endregion Functions


        #region Comands


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
