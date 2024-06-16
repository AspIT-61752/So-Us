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
        private IUserService userService;

        public ObservableCollection<Assignment> TodaysAssignments { get; set; }

        #endregion

        #region Constructors

        public MainPageViewModel(ISosuService sosuService, IUserService userService)
        {
            Title = "SoUs Care App";
            this.sosuService = sosuService;
            TodaysAssignments = new ObservableCollection<Assignment>();
            this.userService = userService;
            UpdateAssignmentsAsync();
        }

        [RelayCommand]
        private async Task UpdateAssignmentsAsync()
        {
            try
            {
                // Shows the user a loading spinner
                IsBusy = true;

                userService.SetUserId(1);
                DateTime today = DateTime.Now;

                TodaysAssignments.Clear();

                //var assignments = await sosuService.GetAssignmentsForAsync(today, new Employee { EmployeeId = 1 });
                // https://localhost:7096/api/Assignment/GetByDate?EmployeeId=1&date=2024-06-16 // It'll use 10.0.2.2 instead of localhost, but this is just so I can see what data it should get
                var assignments = await sosuService.GetAssignmentsForAsync(today, new Employee { EmployeeId = userService.GetUserId() });
                Console.WriteLine($"UserID: {userService.GetUserId()}");

                // Get the assignments for the current user on today's date and add them to the list of todays assignments
                UpdateAssignments(assignments);

                foreach (var item in assignments)
                {
                    Console.WriteLine(item);
                }

                if (TodaysAssignments.Count == 0)
                {
                    Console.WriteLine($"UserID: {userService.GetUserId()}");
                    await Shell.Current.DisplayAlert("INFO", "No assignments today", "OK");
                    Employee employee = new Employee { EmployeeId = 1, Name = "Mike" };
                    List<Employee> employees = new();
                    employees.Add(employee);
                    TodaysAssignments.Add(new Assignment { AssignmentId = 0, Employees = employees, Name = "Giv medicin", Resident = new Resident { Name = "Tommas" }, TimeStart = DateTime.Now.AddMinutes(3), TimeEnd = DateTime.Now.AddMinutes(18), IsComplete = false });
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

        private void UpdateAssignments(List<Assignment> assignments)
        {
            //TodaysAssignments.Clear();
            foreach (var assignment in assignments)
            {
                TodaysAssignments.Add(assignment);
            }
        }

        #endregion

        #region Properties

        #endregion
    }
}
