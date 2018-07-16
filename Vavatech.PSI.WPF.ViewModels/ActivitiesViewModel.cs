using System.Collections.Generic;
using Vavatech.PSI.WPF.IServices;
using Vavatech.PSI.WPF.MockServices;
using Vavatech.PSI.WPF.Models;

namespace Vavatech.PSI.WPF.ViewModels
{
    public class ActivitiesViewModel : BaseViewModel
    {

        public IList<Activity> Activities { get; set; }
        public Activity SelectedActivity { get; set; }

        private readonly IActivitiesService activitiesService;

        public ActivitiesViewModel()
            : this(new MockActivitiesService(new MockEmployeesService()))
        {

        }

        public ActivitiesViewModel(IActivitiesService activitiesService)
        {
            this.activitiesService = activitiesService;

            Load();
        }

        private void Load()
        {
            Activities = activitiesService.Get();
        }

    }
}
