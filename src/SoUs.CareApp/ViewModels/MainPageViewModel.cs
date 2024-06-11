using CommunityToolkit.Mvvm.Input;
using SoUs.Entity;
using SoUs.Services;
using System.Collections.ObjectModel;

namespace SoUs.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        #region Fields

        private readonly ISosuService sosuService;
        private readonly IUserService userService;

        public ObservableCollection<Assignment> TodaysAssignments { get; set; }

        #endregion

        #region Constructors

        public MainPageViewModel(ISosuService sosuService, IUserService userService)
        {
            Title = "SoUs Care App";
            this.sosuService = sosuService;
            TodaysAssignments = new ObservableCollection<Assignment>();
            this.userService = userService;
            UpdateAssignments();
        }

        [RelayCommand]
        private async Task UpdateAssignments()
        {
            try
            {
                // Shows the user a loading spinner
                IsBusy = true;

                // Clear the current list of assignments
                TodaysAssignments.Clear();

                userService.SetUserId(1);
                Console.WriteLine($"UserID: {userService.GetUserId()}");

                // Get the assignments for the current user on today's date and add them to the list of todays assignments
                var assignments = await sosuService.GetAssignmentsForAsync(DateTime.Now, new Employee { EmployeeId = userService.GetUserId() });
                foreach (var assignment in assignments)
                {
                    TodaysAssignments.Add(assignment);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }

        #endregion

        #region Properties

        #endregion
    }
}
