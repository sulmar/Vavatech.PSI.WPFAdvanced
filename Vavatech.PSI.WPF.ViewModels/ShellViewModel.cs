using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vavatech.PSI.WPF.Common;

namespace Vavatech.PSI.WPF.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        // PM> Install-Package PropertyChanged.Fody
        public BaseViewModel SelectedViewModel { get; set; }
        
        public ShellViewModel()
        {
            SelectedViewModel = new EmployeesViewModel();

            ShowActivitiesCommand = new RelayCommand(p => ShowActivities(), p => CanShowActivities);
            ShowEmployeesCommand = new RelayCommand(p => ShowEmployees());
        }


        public ICommand ShowActivitiesCommand { get; private set; }
        public ICommand ShowEmployeesCommand { get; private set; }

        public void ShowActivities()
        {
            SelectedViewModel = new ActivitiesViewModel();
        }

        public bool CanShowActivities => true;


        public void ShowEmployees()
        {
            SelectedViewModel = new EmployeesViewModel();
        }


    }
}
