using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1.MVVM.ViewModel
{
    public class MainWindowVM : BaseVM
    {

       
        static public Action<BaseVM> OnRequestVMChange;

        #region Commands
        #endregion
        #region Variables

        /// <summary>
        /// this the current view model where the user stand
        /// </summary>
        private BaseVM _currentVM;
        public BaseVM CurrentVM
        {
            get => _currentVM;
            set
            {
                //come from CommunotyToolsKit => Notify binding variables to display
                // informations in the view
                SetProperty(ref _currentVM, value);
                OnPropertyChanged(nameof(CurrentVM));
            }
        }



        #endregion

 
        public MainWindowVM()
        {
    
            MainWindowVM.OnRequestVMChange += HandleRequestViewChange;

         
            MainWindowVM.OnRequestVMChange?.Invoke(new MainViewVM());

        }

        /// <summary>
        /// Called when Event Invoke (OnRequestVMChange)
        /// </summary>
        /// <param name="a_VMToChange"></param>
        public void HandleRequestViewChange(BaseVM a_VMToChange)
        {
          
            CurrentVM?.OnHideVM();

         
            CurrentVM = a_VMToChange;

        
            CurrentVM?.OnShowVM();
        }

    }
}
