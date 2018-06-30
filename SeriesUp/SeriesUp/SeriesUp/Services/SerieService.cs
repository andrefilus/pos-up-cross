using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SeriesUp.Infra;
using SeriesUp.Models;

namespace SeriesUp.Services
{
    public class SerieService : ISerieService
    {
        readonly ITmdbApi _api;

        public SerieService(ITmdbApi api)
        {
            _api = api;
        }

        public async Task<SerieResponse> GetSeriesAsync()
        {
            return await _api.GetSerieResponseAsync(AppSettings.ApiKey);
        }
    }
}
