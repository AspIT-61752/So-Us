using SoUs.Entity;
using System.Net.Http.Json;

namespace SoUs.Services
{
    public abstract class ApiBase
    {
        #region Fields

        protected Uri baseUri;
        protected HttpClient client;

        #endregion

        #region Constructors

        protected ApiBase(Uri apiUri)
        {
            baseUri = apiUri;
            client = InitializeHttpClient();
        }

        protected ApiBase(string uri) : this(new Uri(uri)) { }

        private HttpClient InitializeHttpClient()
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
            };

            HttpClient client = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromSeconds(10)
            };

            return client;
        }

        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string url)
        {
            Uri requestUri = new Uri(baseUri, url);

            // Call API
            HttpResponseMessage response = await client.GetAsync(requestUri.ToString()); // IT FAILS HERE! I think... The app just continues here, but I'm not sure why. The status code is OK, but maybe the data is wrong?

            // Check if response is successful
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            // Return response to caller
            return response;
        }

        protected virtual async Task<HttpResponseMessage> PutHttpAsync(string url, Assignment assignment)
        {
            Uri requestUri = new Uri(baseUri, url);

            // Call API
            HttpResponseMessage response = await client.PutAsJsonAsync(requestUri, assignment);

            // Check if response is successful
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            // Return response to caller
            return response; // I don't think this is necessary, but I'll leave it in for now
        }

        #endregion
    }

    public class SosuService : ApiBase, ISosuService
    {
        public SosuService(Uri apiUri) : base(apiUri) { }

        public SosuService(string apiUri) : base(apiUri) { }

        public async Task<List<Assignment>> GetAssignmentsForAsync(DateTime date, Employee employee)
        {
            try
            {
                //List<Assignment> assignments = new List<Assignment>();
                // TODO: Set breakpoint here. It fails here for some reason.
                string url = @$"Assignment/GetByDate?EmployeeId={employee.EmployeeId}&date={date.ToString("yyyy-MM-dd")}";

                var response = await GetHttpAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidDataException("Could not get assignments from API");
                }

                var res = response.Content.ReadFromJsonAsAsyncEnumerable<Assignment>(); // OMG I FORGOT TO GET THE DATA FROM THE RESPONSE!

                List<Assignment> assignments = await res.ToListAsync(); // IT STILL WON'T WORK! I think it's because the data it's receiving is wrong, but I'm not sure why

                return assignments;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Could not get assignments from API", ex);
            }
        }

        public void UpdateAssignment(Assignment assignment)
        {
            try
            {
                PutHttpAsync("Assignment", assignment);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    public interface ISosuService
    {
        Task<List<Assignment>> GetAssignmentsForAsync(DateTime date, Employee employee);
        void UpdateAssignment(Assignment assignment);
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
