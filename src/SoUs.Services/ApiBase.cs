using SoUs.Entity;
using System.Net.Http.Json;

namespace SoUs.Services
{
    public abstract class ApiBase
    {
        #region Fields

        protected Uri baseUri;

        #endregion

        #region Constructors

        protected ApiBase(Uri apiUri)
        {
            baseUri = apiUri;
        }

        protected ApiBase(string uri) : this(new Uri(uri)) { }

        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string url, int EmployeeId, DateTime date)
        {
            UriBuilder uriBuilder = new UriBuilder(baseUri + url);
            uriBuilder.Query = $"EmployeeId={EmployeeId}&date={date}";

            // Call API
            using HttpClient client = new HttpClient();
            var response = await client.GetAsync(uri);

            // Return response to caller
            return response;
        }

        #endregion
    }

    public class SosuService : ApiBase, ISosuService
    {
        public SosuService(Uri apiUri) : base(apiUri) { }

        public SosuService(string apiUri) : base(apiUri) { }

        public async Task<List<Assignment>> GetAssignmentsForAsync(DateTime date, Employee employee)
        {
            string url = @"Assignment/GetByDate";
            var response = await GetHttpAsync(url);
            var result = response.Content.ReadFromJsonAsAsyncEnumerable<Assignment>();
            List<Assignment> assignments = await result.ToListAsync();
            return assignments;
        }
    }

    public interface ISosuService
    {
        Task<List<Assignment>> GetAssignmentsForAsync(DateTime date, Employee employee);
    }

    public interface IUserService
    {
        void SetUserId(int id);
        int GetUserId();
    }

    // I could just use property, but I think having a method is better for this case
    public class UserService : IUserService
    {
        private int userId;

        public int GetUserId()
        {
            return userId;
        }

        public void SetUserId(int id)
        {
            userId = id;
        }
    }
}
