using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsBlog.Models
{
    public class NewsAPIConfig
    {
        public static async Task<List<Article>> GetArticlesAsync(string country)
        {
            // Initialise with the provided API KEY
            var newsApiClient = new NewsApiClient("4c4048f805584bf5996487f8c7a24e3c");
            var countryAPI = Countries.GB; // Great Britain by default

            // Check if passed country matches any of the countries listed
            // And convert it to enum
            if (!string.IsNullOrEmpty(country))
            {
                var arr = Enum.GetNames(typeof(Countries));

                foreach (var c in arr)
                {
                    if (c.Equals(country))
                    {
                        Enum.TryParse(country, out Countries match);
                        countryAPI = match;
                    }

                }
            }

            // Make the request for top headlines
            var articlesResponse = await newsApiClient.GetTopHeadlinesAsync(new TopHeadlinesRequest
            {
                Country = countryAPI,
                Language = Languages.EN,
            });


            // If OK return articles
            if (articlesResponse.Status.Equals(Statuses.Ok))
            {
                return articlesResponse.Articles;
            }

            return null;
        }
    }
}