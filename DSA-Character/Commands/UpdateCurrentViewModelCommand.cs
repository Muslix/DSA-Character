using DSA_Character.State.Navigators;
using DSA_Character.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DSA_Character.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private INavigator navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            this.navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Home:
                        navigator.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewType.Charakter:
                        navigator.CurrentViewModel = new CharacterViewModel();
                        break;
                    case ViewType.Stuff:
                        break;
                   
                }
            }
        }
    }
}
