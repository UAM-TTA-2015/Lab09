using System.Collections.Generic;
using System.Windows.Input;
using UamTTA.GUI.Contracts;

namespace UamTTA.GUI.ViewModels
{
    public interface IMainWindowViewModel
    {
        ICollection<Budget> Budgets { get; }

        ICommand GetBudgetsCommand { get; }
    }
}