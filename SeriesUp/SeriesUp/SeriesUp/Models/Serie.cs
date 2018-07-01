using Newtonsoft.Json;
using SeriesUp.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeriesUp.Models
{
    public class Serie
    {
        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_air_date")]
        public DateTimeOffset FirstAirDate { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonIgnore]
        public string Backdrop { get { return $"{AppSettings.ApiImageBaseUrl}{BackdropPath}"; } }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonIgnore]
        public string Poster { get { return $"{AppSettings.ApiImageBaseUrl}{PosterPath}"; } }

        [JsonIgnore]
        public string ReleaseDate { get { return $"{FirstAirDate:dd/mm/yyyy}"; } }
    }
}
