using System.Collections.Generic;
using System.Windows.Input;
using Vavatech.PSI.WPF.Common;
using Vavatech.PSI.WPF.IServices;
using Vavatech.PSI.WPF.MockServices;
using Vavatech.PSI.WPF.Models;
using System.Threading.Tasks;

namespace Vavatech.PSI.WPF.ViewModels
{
    public class ActivitiesViewModel : BaseViewModel
    {

        public IList<Activity> Activities { get; set; }
        public Activity SelectedActivity { get; set; }

        private readonly IActivitiesService activitiesService;

        public ICommand LoadCommand { get; private set; }

        public bool IsBusy { get; set; }


        public ActivitiesViewModel()
            : this(new MockActivitiesService(new MockEmployeesService()))
        {

        }

        public ActivitiesViewModel(IActivitiesService activitiesService)
        {
            this.activitiesService = activitiesService;

            LoadCommand = new RelayCommand(p => LoadAsync());

          

            
        }


        private void Load()
        {
            LoadAsync().Wait();
        }

        private async Task LoadAsync()
        {
            IsBusy = true;
            Activities = await activitiesService.GetAsync();
            IsBusy = false;
        }

    }
}
