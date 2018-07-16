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

        public BaseViewModel SelectedViewModel { get; set; }
        
        public ShellViewModel()
        {
            SelectedViewModel = new EmployeesViewModel();

            ShowActivitiesCommand = new RelayCommand(p => ShowActivities(), p => CanShowActivities);
        }


        public ICommand ShowActivitiesCommand { get; private set; }

        public void ShowActivities()
        {
            SelectedViewModel = new ActivitiesViewModel();
        }

        public bool CanShowActivities => true;

    }
}
