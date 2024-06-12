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
            HttpResponseMessage response = await client.GetAsync(requestUri);

            // Check if response is successful
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

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
            try
            {
                List<Assignment> assignments = new List<Assignment>();

                string url = @$"Assignment/GetByDate?EmployeeId={employee.EmployeeId}&date={date.ToString("yyyy-MM-dd")}";
                
                var response = await GetHttpAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidDataException("Could not get assignments from API");
                }

                assignments = await response.Content.ReadFromJsonAsync<List<Assignment>>();

                return assignments;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Could not get assignments from API", ex);
            }
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
