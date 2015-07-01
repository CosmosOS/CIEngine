using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Cosmos.CIEngine.GithubClient.Objects;

namespace Cosmos.CIEngine.GithubClient
{
    public class GithubClient
    {
        private HttpClient mHttpClient;

        public GithubClient()
        {
            mHttpClient = new HttpClient();

            mHttpClient.DefaultRequestHeaders.Add("User-agent", "CosmosCIEngine");
            mHttpClient.BaseAddress = new Uri("https://api.github.com/");
        }

        public async Task<Tuple<List<Event>, string>> GetEventsForRepositoryAsync(string owner, string repository, string currentETag)
        {
            const int pageSize = 100;
            var xCurrentPage = 1;
            var xUrlList = new List<string>();
            var xResultList = new List<Event>();
            string xResultETag = null;
            string xUrlToGet = String.Format("/repos/{0}/{1}/events?page={2}&per_page={3}", owner, repository, xCurrentPage, pageSize);
            do
            {
                var xRequest = new HttpRequestMessage(HttpMethod.Get, xUrlToGet);

                if (!String.IsNullOrWhiteSpace(currentETag))
                {
                    xRequest.Headers.Add("If-None-Match", currentETag);
                }

                var xResult = await mHttpClient.SendAsync(xRequest, HttpCompletionOption.ResponseHeadersRead);
                if (xResult.StatusCode == HttpStatusCode.NotModified)
                {
                    break;
                }

                if (!xResult.IsSuccessStatusCode)
                {
                    xResult.EnsureSuccessStatusCode();
                }
                if (String.IsNullOrWhiteSpace(xResultETag))
                {
                    xResultETag = xResult.Headers.ETag.Tag;
                }


                var xResultItems = await xResult.Content.ReadAsAsync<Event[]>();
                xResultList.AddRange(xResultItems);
                xUrlList.Add(xUrlToGet);

                var xLink = xResult.Headers.GetValues("Link").Single();
                //Link: <https://api.github.com/repositories/27551693/events?page=1&per_page=100>; rel="first", <https://api.github.com/repositories/27551693/events?page=2&per_page=100>; rel="prev"
                if (!xLink.Contains('>'))
                {
                    break;
                }

                var xLinkRel = xLink.Substring(xLink.IndexOf(';') + 1).Trim();
                if (xLinkRel.StartsWith("rel=\"first\""))
                {
                    break;
                }
                xLink = xLink.Substring(0, xLink.IndexOf('>')).Substring(1);

                if (xLink == xUrlToGet)
                {
                    break;
                }

                if (xUrlList.Contains(xLink))
                {
                    break;
                }
                xUrlToGet = xLink;

            }
            while (true);

            return Tuple.Create(xResultList, xResultETag);
        }
    }
}
