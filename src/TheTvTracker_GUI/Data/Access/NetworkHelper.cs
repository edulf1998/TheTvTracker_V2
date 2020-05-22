using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using TheTvTracker.Data.Model;

namespace TheTvTracker.Data.Access
{
  public sealed class NetworkHelper
  {
    private static readonly Lazy<NetworkHelper> lazy = new Lazy<NetworkHelper>(() => new NetworkHelper());
    public static NetworkHelper Instance
    {
      get => lazy.Value;
    }

    private string posterPath = @"https://image.tmdb.org/t/p/original";
    private string searchMovies = @"https://api.themoviedb.org/3/search/movie?api_key={0}&language=es-ES&region=ES&query={1}";
    private string movieData = @"https://api.themoviedb.org/3/movie/{0}?api_key={1}&language=es-ES&region=ES";

    public async Task<IList<Movie>> SearchMovies(string query)
    {
      List<Movie> results = new List<Movie>();

      string url = string.Format(searchMovies, API_Keys.API_KEY, query);
      var client = new RestClient(url);
      var req = new RestRequest(Method.GET);
      var res = await client.ExecuteAsync(req);
      string json = res.Content;

      JObject jObj = JObject.Parse(json);
      var movieResults = jObj["results"].Children();

      string movieId;
      Movie m;
      foreach (JToken token in movieResults)
      {
        movieId = token["id"].ToString();

        try
        {
          m = await GetMovieData(movieId);
          results.Add(m);
        }
        catch (Exception)
        {
        }
      }
      return results;
    }

    public async Task<Movie> GetMovieData(string id)
    {
      Movie movie;

      string url = string.Format(movieData, id, API_Keys.API_KEY);
      var client = new RestClient(url);
      var req = new RestRequest(Method.GET);
      var res = await client.ExecuteAsync(req);
      string json = res.Content;

      JObject jObj = JObject.Parse(json);

      CheckDownloaded(posterPath + jObj["poster_path"].ToString(), jObj["poster_path"].ToString());

      movie = new Movie { Summary = jObj["overview"].ToString(), Poster = $"Img{Path.DirectorySeparatorChar}{jObj["poster_path"]}", Name = jObj["title"].ToString() };
      return movie;
    }

    private void CheckDownloaded(string completeUrl, string partialUrl)
    {
      var path = $"Img{Path.DirectorySeparatorChar}{partialUrl}";

      if (!Directory.Exists("Img"))
      {
        Directory.CreateDirectory("Img");
      }

      if (!File.Exists(path))
      {
        using (WebClient c = new WebClient())
        {
          c.DownloadFileAsync(new Uri(completeUrl), path);
        }
      }
    }
  }
}
