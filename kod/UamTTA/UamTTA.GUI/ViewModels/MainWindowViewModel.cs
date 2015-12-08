using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using UamTTA.GUI.Contracts;
using UamTTA.GUI.Controllers;

namespace UamTTA.GUI.ViewModels
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        public ICollection<Budget> Budgets { get; private set; }

        public ICommand GetBudgetsCommand { get; private set; }

        public MainWindowViewModel(IMainWindowController controller)
        {
            controller.ViewModel = this;

            Budgets = new ObservableCollection<Budget>();
            GetBudgetsCommand = new DelegateCommand(controller.OnGetBudget);
        }
    }
}