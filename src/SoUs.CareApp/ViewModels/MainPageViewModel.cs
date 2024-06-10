using SoUs.Entity;
using SoUs.Services;
using System.Collections.ObjectModel;

namespace SoUs.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        #region Fields

        private readonly ISosuService sosuService;


        public ObservableCollection<Assignment> TodaysAssignments { get; } = new();

        #endregion

        #region Constructors

        public MainPageViewModel(ISosuService sosuService, IUserService userService)
        {
            Title = "SoUs Care App";
            this.sosuService = sosuService;
            UpdateAssignments();
        }

        private async Task UpdateAssignments()
        {
            TodaysAssignments.Clear();
            var assignments = await sosuService.GetAssignmentsForAsync(DateTime.Now, new Employee() { EmployeeId = 1 });
        }

        #endregion

        #region Properties

        #endregion
    }
}
