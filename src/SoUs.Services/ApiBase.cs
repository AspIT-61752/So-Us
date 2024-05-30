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

        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string url)
        {
            // Build URI to ensure it is correct
            Uri uri = new("");

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
            string url = "";
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
}
